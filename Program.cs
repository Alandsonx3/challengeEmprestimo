using challengeEmprestimo.Entities;

List <Loan> loans = new List<Loan>();

string[] names = ["Maria", "Carlos", "Bruna", "Miguel", "Junior", "Felipe", "José", "Alandson", "Kelly", "Eslaine",
                "Matheus", "Ricardo", "João", "Breno", "Ana", "Maisa", "Carla", "Joana", "Elisa", "Wellington"];

string[] lastNames = ["Gonçalves", "Rodrigues", "Almeida", "Silva", "Gomides", "Macedo", "Lima", "Pereira", "Gomes",
                    "Botelho", "Faria", "Santos", "Madasceno", "Bitencour", "Seixas", "Linber"];

Console.Write("Digite quantas emprestimos deseja registrar: ");
int value = int.Parse(Console.ReadLine()!);


for(int i = 0; i < value; i++ )
{
    var random = new Random();
    var instituitionRandom = random.Next(4);

    var nameUser = names[random.Next(names.Length -1)];
    var lastNameUser = lastNames[random.Next(lastNames.Length -1)];

    var amount = (decimal)random.Next(1000, 100001);

    Loan loanInstant = instituitionRandom switch
    {
        0 => new LoanBradesco($"{nameUser} {lastNameUser}", amount),
        2 => new LoanNubank($"{nameUser} {lastNameUser}", amount),
        3 => new LoanPicPay($"{nameUser} {lastNameUser}", amount),
        _ => new LoanItau($"{nameUser} {lastNameUser}", amount)
    };

    loans.Add(loanInstant);
}

var count = 0;
foreach(var loan in loans.OrderBy(x => x.ClientName))
{
    loan.CalculateValueInterest();
    Console.WriteLine($"{++count}\t{loan}");
    Thread.Sleep(5);
}

do
{
    Console.Write("\nNome que deseja pesquisar: ");
    var search = Console.ReadLine();
    IEnumerable<Loan> result = loans.Where(x => x.ClientName == search);
    var sum = result.Sum(x => x.GetTotalToPay());
    var countLoans = result.Count();

    count = 0;
    Console.WriteLine();
    foreach(var r in result)
    {
        r.CalculateValueInterest();
        Console.WriteLine($"{++count}\t{r}");
    }

    Console.WriteLine($"\nTotal em emprestimos: {sum:c2}");
    Console.WriteLine($"\nTotal de emprestimos: {countLoans}");

} while(true);