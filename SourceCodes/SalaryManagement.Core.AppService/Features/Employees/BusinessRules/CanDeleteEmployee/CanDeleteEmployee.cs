using Framework.Contracts.BusinessRule;

namespace SalaryManagement.Core.AppService.Features.Employees.BusinessRules.CanDeleteEmployee
{
    public class CanDeleteEmployee : ICanDeleteEmployee
    {

        public CanDeleteEmployee()
        {
        }

        public BusinessRuleResult Check(CanDeleteEmployeeContext context)
        {
            var result = new BusinessRuleResult();


            return result;
        }
    }
}
