namespace challengeEmprestimo.Entities
{
    public class LoanItau : Loan
    {
        public LoanItau(string clientName, decimal loanAmount) : base(clientName, loanAmount) {}
        public sealed override void CalculateValueInterest()
        {
            decimal InterestRate = 0.12m; // Standard interest rate 12%
            InterestValue = LoanAmount * InterestRate;
            Institution = "Itau    ";
        }
    }
}