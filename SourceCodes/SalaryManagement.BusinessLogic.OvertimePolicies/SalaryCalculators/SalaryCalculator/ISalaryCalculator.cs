using Framework.Contracts.BusinessCalculator;

namespace SalaryManagement.BusinessLogic.OvertimePolicies.SalaryCalculators.SalaryCalculator
{
    public interface ISalaryCalculator : IBusinessCalculator<SalaryCalculatorContext, double>
    {

    }
}
