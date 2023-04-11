
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using SalaryManagement.BusinessLogic.OvertimePolicies;
using SalaryManagement.Core.AppService;
using SalaryManagement.Core.Infrastructure;

namespace SalaryManagement.Core.IOC
{
    public static class ServiceRegistration
    {
        public static IServiceCollection Register(this IServiceCollection services,IConfiguration configuration)
        {

            services.RegisterAppService(configuration);
            services.RegisterBusinessLogic(configuration);
            services.RegisterInfrastructure(configuration);

            return services;
        }
    }
}