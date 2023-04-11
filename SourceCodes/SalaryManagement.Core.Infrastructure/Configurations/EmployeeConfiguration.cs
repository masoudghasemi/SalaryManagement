using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaryManagement.Core.Domain.Entities;

namespace SalaryManagement.Core.Infrastructure.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {


        builder.Property(t => t.FirstName)
            .IsRequired()
            .HasMaxLength(100);


        builder.Property(t => t.LastName)
            .IsRequired()
            .HasMaxLength(100);


        builder.Property(t => t.Date)
            .IsRequired()
            ;

        builder.Property(t => t.Allowance)
            .IsRequired();

        builder.Property(t => t.BasicSalary)
            .IsRequired();

        builder.Property(t => t.Transportation)
            .IsRequired();


        builder.Property(t => t.OverTimeCalculator)
            .IsRequired()
            .HasMaxLength(100);

    }
}
