using Microsoft.Extensions.DependencyInjection;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorA;
using SalaryManagement.BusinessLogic.OvertimePolicies.TaxCalculators.TaxCalculator;

namespace SalaryManagement.UnitTests.BusinessLogic.TaxCalculators
{
    public class TaxCalculatorUnitTests: Testing
    {


        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TaxCalculatorUnitTests_Calculate()
        {
            var _service = ServiceProvider.GetService<ITaxCalculator>();

            var context = new TaxCalculatorContext
            {
                Salary = 1200.5
            };

            var result = _service.Calculate(context);

            Assert.AreEqual(120, (int)result);

        }
    }
}