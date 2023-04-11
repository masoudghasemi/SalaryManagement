namespace SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorC
{
    public  class OverTimeCalculatorC  :OverTimeCalculator.OverTimeCalculator, IOverTimeCalculatorC
    {
        public virtual double Calculate(OverTimeCalculatorCContext context)
        {
            var baseValue = base.Calculate(context);
           
            // more logic  

            return baseValue;
        }


    }
}