
namespace challengeEmprestimo.Application
{
    public class CreateUserFake
    {
        private string[] names = ["Maria", "Carlos", "Bruna", "Miguel", "Junior", "Felipe", "José", "Alandson", "Kelly", "Eslaine",
                "Matheus", "Ricardo", "João", "Breno", "Ana", "Maisa", "Carla", "Joana", "Elisa", "Wellington"];

        private string[] lastNames = ["Gonçalves", "Rodrigues", "Almeida", "Silva", "Gomides", "Macedo", "Lima", "Pereira", "Gomes",
                    "Botelho", "Faria", "Santos", "Madasceno", "Bitencour", "Seixas", "Linber"];

        public string Create()
        {
                var random = new Random();
                var nameUser = names[random.Next(names.Length -1)];
                var lastNameUser = lastNames[random.Next(lastNames.Length -1)];

                return $"{nameUser} {lastNameUser}";
        }
    }
}