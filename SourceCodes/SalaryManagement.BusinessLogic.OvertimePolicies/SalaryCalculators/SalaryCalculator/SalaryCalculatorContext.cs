

namespace SalaryManagement.BusinessLogic.OvertimePolicies.SalaryCalculators.SalaryCalculator
{
    public class SalaryCalculatorContext
    {
        public long BasicSalary { get; set; }
        public long Allowance { get; set; }
        public long Transportation { get; set; }

        public string OverTimeCalculator { get; set; }

        public int OverTimeMinutes { get; set; }




    }
}
