namespace SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculator
{
    public  class OverTimeCalculator  : IOverTimeCalculator
    {
        public virtual  double Calculate(OverTimeCalculatorContext context)
        {
            double salaryPerMonth = context.Allowance+context.BasicSalary ;

            var salaryPerHour = salaryPerMonth / 192;

            var salaryPerMinute = salaryPerHour / 60;

            var overtimeSalary = salaryPerMinute * context.OverTimeMinutes * 1.4;

            return overtimeSalary;
        }


    }
}