using SalaryManagement.Core.AppService.Features.Employees.Services.Commands.UpdateEmployee;
using SalaryManagement.Core.Domain.Entities;

namespace SalaryManagement.Core.AppService.Features.Employees.BusinessRules.CanUpdateEmployee
{
    public class CanUpdateEmployeeContext
    {
        public UpdateEmployeeCommand? Request { get; set; }
        public  Employee? Entity { get; set; }

    }
}
