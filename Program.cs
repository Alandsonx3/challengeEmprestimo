using Microsoft.Extensions.DependencyInjection;
using challengeEmprestimo.Application;
using challengeEmprestimo.IoC;


var services = new ServiceCollection();

services.AddProjectService();

var provider = services.BuildServiceProvider();

// 🔥 PEGAR O SERVICE
var loanService = provider.GetRequiredService<LoanService>();

Console.Write("Digite quantos emprestimos deseja registrar: ");
int quantify = int.Parse(Console.ReadLine()!);

// 🔥 EXECUTAR
await loanService.Create(quantify);

// 🔥 LISTAR
var loans = await loanService.GetLoans();

int count = 0;
foreach (var loan in loans)
{
    Console.WriteLine($"{++count}\t{loan}");
}