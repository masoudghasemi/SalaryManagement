using Framework.Contracts.BusinessCalculator;

namespace SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculator
{
    public interface IOverTimeCalculator : IBusinessCalculator<OverTimeCalculatorContext, double>
    {

    }
}
