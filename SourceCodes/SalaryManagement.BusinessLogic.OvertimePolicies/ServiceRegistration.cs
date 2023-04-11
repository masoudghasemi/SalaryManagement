using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculator;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorA;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorB;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorC;
using SalaryManagement.BusinessLogic.OvertimePolicies.SalaryCalculators.SalaryCalculator;
using SalaryManagement.BusinessLogic.OvertimePolicies.TaxCalculators.TaxCalculator;

namespace SalaryManagement.BusinessLogic.OvertimePolicies
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterBusinessLogic(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IOverTimeCalculator, OverTimeCalculator>();
            services.AddScoped<IOverTimeCalculatorA, OverTimeCalculatorA>();
            services.AddScoped<IOverTimeCalculatorB, OverTimeCalculatorB>();
            services.AddScoped<IOverTimeCalculatorC, OverTimeCalculatorC>();
            services.AddScoped<ISalaryCalculator, SalaryCalculator>();
            services.AddScoped<ITaxCalculator, TaxCalculator>();
            

            return services;
        }




    }
}