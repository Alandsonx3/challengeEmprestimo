namespace challengeEmprestimo.Entities
{
    public class LoanNubank : Loan
    {
        public LoanNubank(string clientName, decimal loanAmount) : base(clientName, loanAmount) {}
        public sealed override void CalculateValueInterest()
        {
            decimal InterestRate = 0.18m; // Standard interest rate 18%
            InterestValue = LoanAmount * InterestRate;
            Institution = "Nubank  ";

        }
    }
}