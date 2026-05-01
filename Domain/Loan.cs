
namespace challengeEmprestimo.Entities
{
    public class Loan
    {
        public int Id {get; set;}
        public string ClientName {get; set;} = string.Empty;
        public decimal LoanAmount {get; set;}
        public decimal InterestValue {get; set;}

        public string Institution {get; set;} = string.Empty;

        public decimal GetTotalToPay ()
        {
            return LoanAmount + InterestValue;
        }

        public override string ToString()
        {
            return $"{ClientName,-20} | " +
                $"{Institution,-10} | " +
                $"{LoanAmount,12:c2} | " +
                $"{InterestValue,12:c2} | " +
                $"{GetTotalToPay(),12:c2}";
        }
    }
}