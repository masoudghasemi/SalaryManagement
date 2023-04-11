using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalaryManagement.Core.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mgh_01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BasicSalary = table.Column<long>(type: "bigint", nullable: false),
                    Allowance = table.Column<long>(type: "bigint", nullable: false),
                    Transportation = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<int>(type: "int", nullable: false),
                    OverTimeCalculator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OverTimeMinutes = table.Column<int>(type: "int", nullable: true),
                    FinalSalary = table.Column<double>(type: "float", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_FirstName_LastName_Date",
                table: "Employees",
                columns: new[] { "FirstName", "LastName", "Date" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
