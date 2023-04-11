namespace SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorB
{
    public  class OverTimeCalculatorB  :OverTimeCalculator.OverTimeCalculator, IOverTimeCalculatorB
    {
        public virtual double Calculate(OverTimeCalculatorBContext context)
        {
            var baseValue = base.Calculate(context);

            // more logic  
            
            return baseValue;
        }


    }
}