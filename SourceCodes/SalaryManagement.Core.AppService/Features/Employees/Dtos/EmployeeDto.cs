namespace SalaryManagement.Core.AppService.Features.Employees.Dtos
{
    public class EmployeeDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long BasicSalary { get; set; }
        public long Allowance { get; set; }
        public long Transportation { get; set; }
        public int Date { get; set; }


        public string OverTimeCalculator { get; set; }

        public int? OverTimeMinutes { get; set; }


        public double? FinalSalary { get; set; }
    }
}
