using Framework.Models;
using Microsoft.AspNetCore.Mvc;
using SalaryManagement.Core.AppService.Features.Employees.Dtos;
using SalaryManagement.Core.AppService.Features.Employees.Services.Commands.CreateEmployee;
using SalaryManagement.Core.AppService.Features.Employees.Services.Commands.DeleteEmployee;
using SalaryManagement.Core.AppService.Features.Employees.Services.Commands.UpdateEmployee;
using SalaryManagement.Core.AppService.Features.Employees.Services.Queries.GetEmployee;
using SalaryManagement.Core.AppService.Features.Employees.Services.Queries.GetEmployees;

namespace SalaryManagement.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : BaseController
    {

        [HttpPost]
        public async Task<ActionResult<long>> Create(CreateEmployeeCommand command)
        {
            return await Mediator.Send(command);

        }


        [HttpPut]
        public async Task<ActionResult> Update(UpdateEmployeeCommand command)
        {
            await Mediator.Send(command);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            await Mediator.Send(new DeleteEmployeeCommand { Id = id });
            return NoContent();
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDto>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetEmployeeQuery() { Id = id }));
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<PaginatedList<EmployeeDto>>> List([FromQuery] GetEmployeesQuery query)
        {
            return await Mediator.Send(query);
        }

    }
}