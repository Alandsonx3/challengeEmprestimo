using challengeEmprestimo.Infraestructure;
using challengeEmprestimo.Infraestructure.Interfaces;
using challengeEmprestimo.Entities;
using Microsoft.EntityFrameworkCore;

namespace challengeEmprestimo.Application
{
    public class LoanService
    {
        private readonly DatabaseContext _context;
        private readonly List<IInterestRate> _interest;
        private readonly Random _random = new Random();

        public LoanService(DatabaseContext context, IEnumerable<IInterestRate> interest)
        {
            _context = context;
            _interest = interest.ToList();
        }

        public async Task Create(int quantify)
        {
            for (int i = 0; i < quantify; i++)
            {
                var interest = _interest[_random.Next(_interest.Count)];

                var amount = _random.Next(1000, 100001);
                var clientName = new CreateUserFake().Create();

                var loanInstant = new Loan
                {
                    ClientName = clientName,
                    LoanAmount = amount,
                    InterestValue = interest.Calculate(amount),
                    Institution = interest.Institution
                };

                await _context.Loans.AddAsync(loanInstant);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<List<Loan>> GetLoans()
        {
            return await _context.Loans.OrderBy(x => x.ClientName).ToListAsync();
        }

        public async Task<List<Loan>> Search(string name)
        {
            return await _context.Loans
            .Where(x => x.ClientName.Contains(name))
            .ToListAsync();
        }
    }
}