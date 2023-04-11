using Framework.Contracts.BusinessCalculator;

namespace SalaryManagement.BusinessLogic.OvertimePolicies.TaxCalculators.TaxCalculator
{
    public interface ITaxCalculator : IBusinessCalculator<TaxCalculatorContext, double>
    {

    }
}
