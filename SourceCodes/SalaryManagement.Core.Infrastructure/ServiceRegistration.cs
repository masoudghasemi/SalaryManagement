using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalaryManagement.Core.Infrastructure.Context;
using SalaryManagement.Core.Infrastructure.Context.Interfaces;

namespace SalaryManagement.Core.Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                 options.UseSqlServer(
                     configuration.GetConnectionString("DefaultConnection")
                     )
                 );

            services.AddScoped<IAppDbContext>(provider => provider.GetRequiredService<AppDbContext>());

            return services;
        }






    }
}