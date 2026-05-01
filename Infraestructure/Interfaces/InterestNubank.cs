namespace challengeEmprestimo.Infraestructure.Interfaces
{
    public class InterestNubank : IInterestRate
    {
        public string Institution => "Nubank";

        public decimal Calculate(decimal amount)
            => amount * 0.18m;
        }
}