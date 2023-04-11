using SalaryManagement.Core.AppService.Features.Employees.Services.Commands.DeleteEmployee;
using SalaryManagement.Core.Domain.Entities;

namespace SalaryManagement.Core.AppService.Features.Employees.BusinessRules.CanDeleteEmployee
{
    public class CanDeleteEmployeeContext
    {
        public DeleteEmployeeCommand? Request { get; set; }
        public Employee? Entity { get; set; }

    }
}
