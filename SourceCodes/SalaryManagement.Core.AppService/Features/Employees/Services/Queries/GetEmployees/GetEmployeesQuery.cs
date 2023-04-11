using AutoMapper;
using Framework.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SalaryManagement.Core.AppService.Features.Employees.Dtos;
using SalaryManagement.Core.Infrastructure.Context.Interfaces;

namespace SalaryManagement.Core.AppService.Features.Employees.Services.Queries.GetEmployees
{

    public class GetEmployeesQuery : BaseQuery, IRequest<PaginatedList<EmployeeDto>>
    {

        public  int? FromDate { get; set; }
        public int? ToDate { get; set; }
 

        public class Handler : IRequestHandler<GetEmployeesQuery, PaginatedList<EmployeeDto>>
        {
            private readonly IAppDbContext _db;
            private readonly IMapper _mapper;

            public Handler(IAppDbContext db, IMapper mapper)
            {
                _db = db;
                _mapper = mapper;
            }


            public async Task<PaginatedList<EmployeeDto>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
            {
                var query =
                    from employee in _db.Employees.AsNoTracking()
                    where (employee.Date>=request.FromDate || request.FromDate==null)
                    where (employee.Date <= request.ToDate || request.ToDate == null)
                    orderby employee.Id descending
                    select employee;

                var count = query.Count();

                var entities = await query
                    .Skip((request.PageNumber - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .ToListAsync();

                return new PaginatedList<EmployeeDto>(_mapper.Map<List<EmployeeDto>>(entities), count,
                    request.PageNumber, request.PageSize);

            }

        }
    }
}
