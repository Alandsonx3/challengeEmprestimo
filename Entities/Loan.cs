
namespace challengeEmprestimo.Entities
{
    public class Loan
    {
        public string? ClientName {get; set;}
        public decimal LoanAmount {get; set;}
        public decimal InterestValue {get; set;}

        public string? Institution {get; set;}

        public Loan(string clientName, decimal loanAmount)
        {
            ClientName = clientName;
            LoanAmount = loanAmount;
        }

        public virtual void CalculateValueInterest ()
        {            
            decimal InterestRate = 0.20m; // Standard interest rate 20%
            InterestValue = LoanAmount * InterestRate;
            Institution = "Default";
        }

        public decimal GetTotalToPay ()
        {
            return LoanAmount + InterestValue;
        }

        public override string ToString()
        {
            return $"Origem: {Institution} | Total {GetTotalToPay():c2} ({InterestValue:c2}) \t| {ClientName}";
        }
    }
}