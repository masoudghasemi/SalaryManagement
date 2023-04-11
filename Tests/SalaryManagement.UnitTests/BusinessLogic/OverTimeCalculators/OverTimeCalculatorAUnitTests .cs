using Microsoft.Extensions.DependencyInjection;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculator;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorA;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorB;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorC;
using SalaryManagement.BusinessLogic.OvertimePolicies.SalaryCalculators.SalaryCalculator;
using SalaryManagement.BusinessLogic.OvertimePolicies.TaxCalculators.TaxCalculator;

namespace SalaryManagement.UnitTests.BusinessLogic.OverTimeCalculators
{
    public class OverTimeCalculatorAUnitTests : Testing
    {


        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void OverTimeCalculatorUnitTests_Calculate()
        {
            var _overTimeCalculator = ServiceProvider.GetService<IOverTimeCalculatorA>();

            var context = new OverTimeCalculatorAContext
            {
                Allowance = 1000,
                BasicSalary = 1000,
                OverTimeMinutes = 60
            };

            var result = _overTimeCalculator.Calculate(context);

            Assert.AreEqual(14, (int)result);

        }
    }
}