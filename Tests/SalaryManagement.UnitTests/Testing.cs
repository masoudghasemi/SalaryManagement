using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalaryManagement.Core.IOC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculator;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorA;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorB;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorC;
using SalaryManagement.BusinessLogic.OvertimePolicies.SalaryCalculators.SalaryCalculator;
using SalaryManagement.BusinessLogic.OvertimePolicies.TaxCalculators.TaxCalculator;

namespace SalaryManagement.UnitTests;

//[SetUpFixture]
public class Testing
{

    public ServiceProvider ServiceProvider { get; set; }


    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        var services = new ServiceCollection();

        services.AddScoped<IOverTimeCalculator, SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculator.OverTimeCalculator>();
        services.AddScoped<IOverTimeCalculatorA, OverTimeCalculatorA>();
        services.AddScoped<IOverTimeCalculatorB, OverTimeCalculatorB>();
        services.AddScoped<IOverTimeCalculatorC, OverTimeCalculatorC>();
        services.AddScoped<ISalaryCalculator, SalaryCalculator>();
        services.AddScoped<ITaxCalculator, TaxCalculator>();

        ServiceProvider = services.BuildServiceProvider();
    }

}