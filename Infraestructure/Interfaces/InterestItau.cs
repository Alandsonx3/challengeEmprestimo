namespace challengeEmprestimo.Infraestructure.Interfaces
{
    public class InterestItau : IInterestRate
    {
        public string Institution => "Itau";

        public decimal Calculate(decimal amount)
            => amount * 0.12m;
        }
}