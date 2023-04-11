namespace SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorA
{
    public  class OverTimeCalculatorA  : OverTimeCalculator.OverTimeCalculator, IOverTimeCalculatorA
    {
        public virtual  double Calculate(OverTimeCalculatorAContext context)
        {
            var baseValue = base.Calculate(context);

            // more logic  

            return baseValue;

        }
        
    }
}