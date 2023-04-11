using Microsoft.EntityFrameworkCore;
using SalaryManagement.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagement.Core.Infrastructure.Context.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<Employee> Employees { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
