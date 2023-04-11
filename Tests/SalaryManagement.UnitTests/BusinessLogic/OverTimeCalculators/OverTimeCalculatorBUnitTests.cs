using Microsoft.Extensions.DependencyInjection;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculator;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorA;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorB;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorC;
using SalaryManagement.BusinessLogic.OvertimePolicies.SalaryCalculators.SalaryCalculator;
using SalaryManagement.BusinessLogic.OvertimePolicies.TaxCalculators.TaxCalculator;

namespace SalaryManagement.UnitTests.BusinessLogic.OverTimeCalculators
{
    public class OverTimeCalculatorBUnitTests : Testing
    {


        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void OverTimeCalculatorUnitBTests_Calculate()
        {
            var _service = ServiceProvider.GetService<IOverTimeCalculatorB>();

            var context = new OverTimeCalculatorBContext
            {
                Allowance = 1000,
                BasicSalary = 1000,
                OverTimeMinutes = 60
            };

            var result = _service.Calculate(context);

            Assert.AreEqual(14, (int)result);

        }
    }
}