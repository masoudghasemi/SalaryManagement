namespace SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculator
{
    public class OverTimeCalculatorContext
    {
        public long BasicSalary { get; set; }
        public long Allowance { get; set; }

        public int OverTimeMinutes { get; set; }
    }
}
