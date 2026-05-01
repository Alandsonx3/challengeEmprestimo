
namespace challengeEmprestimo.Infraestructure.Interfaces
{
    public interface IInterestRate
    {
        string Institution {get;}
        decimal Calculate(decimal amount);
    }
}