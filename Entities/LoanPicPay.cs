namespace challengeEmprestimo.Entities
{
    public class LoanPicPay : Loan
    {
        public LoanPicPay(string clientName, decimal loanAmount) : base(clientName, loanAmount) {}
        public sealed override void CalculateValueInterest()
        {
            decimal InterestRate = 0.14m; // Standard interest rate 14%
            InterestValue = LoanAmount * InterestRate;
            Institution = "PicPay  ";

        }
    }
}