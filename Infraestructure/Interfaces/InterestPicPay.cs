namespace challengeEmprestimo.Infraestructure.Interfaces
{
    public class InterestPicPay : IInterestRate
    {
        public string Institution => "PicPay";

        public decimal Calculate(decimal amount)
            => amount * 0.14m;
        }
}