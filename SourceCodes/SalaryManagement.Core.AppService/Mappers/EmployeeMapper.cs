using AutoMapper;
using SalaryManagement.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryManagement.Core.AppService.Features.Employees.Dtos;
using SalaryManagement.Core.AppService.Features.Employees.Services.Commands.CreateEmployee;

namespace SalaryManagement.Core.AppService.Mappers
{
    public class EmployeeMapper : Profile
    {
        public EmployeeMapper()
        {


            CreateMap<Employee, EmployeeDto>(MemberList.Destination)

                ;


            CreateMap<CreateEmployeeCommand, Employee>(MemberList.None)
                ;
        }
    }
}
