using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SalaryManagement.Core.AppService.Features.Employees.Dtos;
using SalaryManagement.Core.Infrastructure.Context.Interfaces;

namespace SalaryManagement.Core.AppService.Features.Employees.Services.Queries.GetEmployee
{

    public class GetEmployeeQuery : IRequest<EmployeeDto>
    {
        public long Id { get; set; }
        public class Handler : IRequestHandler<GetEmployeeQuery, EmployeeDto>
        {
            private readonly IAppDbContext _db;
            private readonly IMapper _mapper;

            public Handler(IAppDbContext db, IMapper mapper)
            {
                _db = db;
                _mapper = mapper;
            }


            public async Task<EmployeeDto> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
            {
                var entity = await _db
                               .Employees
                               .AsNoTracking()
                               .SingleOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

                if (entity == null)
                {
                    throw new Exception("not found");
                }

                return _mapper.Map<EmployeeDto>(entity);

            }

        }
    }
}
