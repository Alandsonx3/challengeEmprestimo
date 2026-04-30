namespace challengeEmprestimo.Entities
{
    public class LoanBradesco : Loan
    {
        public LoanBradesco(string clientName, decimal loanAmount) : base(clientName, loanAmount) {}
        public sealed override void CalculateValueInterest()
        {
            decimal InterestRate = 0.16m; // Standard interest rate 16%
            InterestValue = LoanAmount * InterestRate;
            Institution = "Bradesco";
        }
    }
}