using Framework.Exceptions;
using MediatR;
using SalaryManagement.Core.AppService.Features.Employees.BusinessRules.CanDeleteEmployee;
using SalaryManagement.Core.Infrastructure.Context.Interfaces;

namespace SalaryManagement.Core.AppService.Features.Employees.Services.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommand : IRequest<Unit>
    {
        public long Id { get; set; }


        public class Handler : IRequestHandler<DeleteEmployeeCommand, Unit>
        {
            private readonly IAppDbContext _db;
            private readonly ICanDeleteEmployee _canDelete;

            public Handler(IAppDbContext db, ICanDeleteEmployee canDelete)
            {
                _db = db;
                _canDelete = canDelete;
            }

            public async Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
            {
                var entity = _db.Employees.FirstOrDefault(e => e.Id == request.Id);

                var _can = _canDelete.Check(new CanDeleteEmployeeContext { Request = request, Entity = entity });
                if (!_can.Result)
                {
                    throw new BusinessRuleException(_can);
                }

                _db.Employees.Remove(entity);

                await _db.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }


        }
    }
}
