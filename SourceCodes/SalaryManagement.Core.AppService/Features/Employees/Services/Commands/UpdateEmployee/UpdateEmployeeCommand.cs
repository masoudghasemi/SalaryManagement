using Framework.Exceptions;
using MediatR;
using SalaryManagement.Core.AppService.Features.Employees.BusinessRules.CanUpdateEmployee;
using SalaryManagement.Core.Infrastructure.Context.Interfaces;

namespace SalaryManagement.Core.AppService.Features.Employees.Services.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommand : IRequest<Unit>
    {
        public long Id { get; set; }

        public long BasicSalary { get; set; }
        public long Allowance { get; set; }
        public long Transportation { get; set; }


        public class Handler : IRequestHandler<UpdateEmployeeCommand, Unit>
        {
            private readonly IAppDbContext _db;
            private readonly ICanUpdateEmployee _canUpdate;

            public Handler(IAppDbContext db, ICanUpdateEmployee canUpdate)
            {
                _db = db;
                _canUpdate = canUpdate;
            }

            public async Task<Unit> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
            {
                var entity = _db.Employees.FirstOrDefault(e => e.Id == request.Id);

                var _can = _canUpdate.Check(new CanUpdateEmployeeContext { Request = request, Entity = entity });
                if (!_can.Result)
                {
                    throw new BusinessRuleException(_can);
                }

                entity.BasicSalary = request.BasicSalary;
                entity.Allowance = request.Allowance;
                entity.Transportation = request.Transportation;

                await _db.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }


        }
    }
}
