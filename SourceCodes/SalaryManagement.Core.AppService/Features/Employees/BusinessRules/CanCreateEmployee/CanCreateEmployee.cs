using Framework.Contracts.BusinessRule;

namespace SalaryManagement.Core.AppService.Features.Employees.BusinessRules.CanCreateEmployee
{
    public class CanCreateEmployee : ICanCreateEmployee
    {

        public CanCreateEmployee()
        {
        }

        public BusinessRuleResult Check(CanCreateEmployeeContext context)
        {
            var result = new BusinessRuleResult();


            return result;
        }
    }
}
