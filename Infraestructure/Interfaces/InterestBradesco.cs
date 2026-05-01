namespace challengeEmprestimo.Infraestructure.Interfaces
{
    public class InterestBradesco : IInterestRate
    {
        public string Institution => "Bradesco";

        public decimal Calculate(decimal amount)
            => amount * 0.16m;
        }
}