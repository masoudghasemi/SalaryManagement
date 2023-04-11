using AutoMapper;
using Framework.Exceptions;
using MediatR;
using SalaryManagement.BusinessLogic.OvertimePolicies.SalaryCalculators.SalaryCalculator;
using SalaryManagement.Core.AppService.Features.Employees.BusinessRules.CanCreateEmployee;
using SalaryManagement.Core.Domain.Entities;
using SalaryManagement.Core.Infrastructure.Context.Interfaces;

namespace SalaryManagement.Core.AppService.Features.Employees.Services.Commands.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long BasicSalary { get; set; }
        public long Allowance { get; set; }
        public long Transportation { get; set; }
        public int Date { get; set; }

        public string OverTimeCalculator { get; set; }
        public int OverTimeMinutes { get; set; }


        public class Handler : IRequestHandler<CreateEmployeeCommand, long>
        {
            private readonly IAppDbContext _db;
            private readonly ICanCreateEmployee _canCreate;
            private  readonly IMapper _mapper;
            private readonly ISalaryCalculator _salaryCalculator;


            public Handler(
                IAppDbContext db,
                ICanCreateEmployee canCreate,
                IMapper mapper,
                ISalaryCalculator salaryCalculator
                )
            {
                _db = db;
                _canCreate = canCreate;
                _mapper = mapper;
                _salaryCalculator = salaryCalculator;
            }

            public async Task<long> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
            {

                var _can = _canCreate.Check(new CanCreateEmployeeContext { Request = request });
                if (!_can.Result)
                {
                    throw new BusinessRuleException(_can);
                }

                var entity = _mapper.Map<Employee>(request);

                entity.FinalSalary = _salaryCalculator.Calculate(new SalaryCalculatorContext()
                {
                    BasicSalary = request.BasicSalary,
                    Allowance = request.Allowance,
                    Transportation = request.Transportation,
                    OverTimeCalculator = request.OverTimeCalculator,
                    OverTimeMinutes = request.OverTimeMinutes
                    
                });


                await _db.Employees.AddAsync(entity, cancellationToken);

                await _db.SaveChangesAsync(cancellationToken);

                return entity.Id;
            }
        }
    }
}
