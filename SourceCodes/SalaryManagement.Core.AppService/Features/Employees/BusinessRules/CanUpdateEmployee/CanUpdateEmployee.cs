using Framework.Contracts.BusinessRule;

namespace SalaryManagement.Core.AppService.Features.Employees.BusinessRules.CanUpdateEmployee
{
    public class CanUpdateEmployee : ICanUpdateEmployee
    {

        public CanUpdateEmployee()
        {
        }

        public BusinessRuleResult Check(CanUpdateEmployeeContext context)
        {
            var result = new BusinessRuleResult();



            return result;
        }
    }
}
