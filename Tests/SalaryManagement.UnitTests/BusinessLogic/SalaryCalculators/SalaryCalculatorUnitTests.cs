using Microsoft.Extensions.DependencyInjection;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorA;
using SalaryManagement.BusinessLogic.OvertimePolicies.SalaryCalculators.SalaryCalculator;

namespace SalaryManagement.UnitTests.BusinessLogic.SalaryCalculators
{
    public class SalaryCalculatorUnitTests: Testing
    {


        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void SalaryCalculatorUnitTests_Calculate( )
        {
            var _service = ServiceProvider.GetService<ISalaryCalculator>();

            var context = new SalaryCalculatorContext
            {
                Allowance = 1000,
                BasicSalary = 1000,
                Transportation = 100,
                OverTimeMinutes = 60,
                OverTimeCalculator = "OverTimeCalculatorA",
                
            };

            var result = _service.Calculate(context);
            Assert.AreEqual(1903, (int)result);


            context.OverTimeCalculator = "OverTimeCalculatorB";
             result = _service.Calculate(context);
            Assert.AreEqual(1903, (int)result);




            context.OverTimeCalculator = "OverTimeCalculatorC";
            result = _service.Calculate(context);
            Assert.AreEqual(1903, (int)result);

        }
    }
}