using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using SalaryManagement.Core.AppService.Features.Employees.BusinessRules.CanCreateEmployee;
using SalaryManagement.Core.AppService.Features.Employees.BusinessRules.CanDeleteEmployee;
using SalaryManagement.Core.AppService.Features.Employees.BusinessRules.CanUpdateEmployee;

namespace SalaryManagement.Core.AppService
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterAppService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddBusinessRules(configuration);

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            return services;
        }


        public static IServiceCollection AddBusinessRules(this IServiceCollection services, IConfiguration configuration)
        {




            services.AddScoped<ICanCreateEmployee, CanCreateEmployee>();
            services.AddScoped<ICanUpdateEmployee, CanUpdateEmployee>();
            services.AddScoped<ICanDeleteEmployee, CanDeleteEmployee>();


            return services;

        }


    }
}