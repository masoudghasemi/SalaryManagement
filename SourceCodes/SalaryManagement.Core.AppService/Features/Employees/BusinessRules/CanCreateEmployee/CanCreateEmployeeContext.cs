using SalaryManagement.Core.AppService.Features.Employees.Services.Commands.CreateEmployee;

namespace SalaryManagement.Core.AppService.Features.Employees.BusinessRules.CanCreateEmployee
{
    public class CanCreateEmployeeContext
    {
        public CreateEmployeeCommand? Request { get; set; }

    }
}
