
using challengeEmprestimo.Entities;
using Microsoft.EntityFrameworkCore;

namespace challengeEmprestimo.Infraestructure
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Loan> Loans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=loan_database;User Id=sa;Password=@Admin123;TrustServerCertificate=True;");
        }
    }
}