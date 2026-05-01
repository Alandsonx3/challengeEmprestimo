using Microsoft.Extensions.DependencyInjection;
using challengeEmprestimo.Infraestructure;
using challengeEmprestimo.Infraestructure.Interfaces;
using challengeEmprestimo.Application;

namespace challengeEmprestimo.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectService(this IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>();

            services.AddScoped<IInterestRate, InterestBradesco>();
            services.AddScoped<IInterestRate, InterestNubank>();
            services.AddScoped<IInterestRate, InterestPicPay>();
            services.AddScoped<IInterestRate, InterestItau>();

            services.AddScoped<LoanService>();

            return services;
        }
    }
}