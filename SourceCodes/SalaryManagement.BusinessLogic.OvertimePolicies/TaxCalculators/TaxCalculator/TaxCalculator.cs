

namespace SalaryManagement.BusinessLogic.OvertimePolicies.TaxCalculators.TaxCalculator
{
    public  class TaxCalculator  : ITaxCalculator
    {
        

        public virtual  double Calculate(TaxCalculatorContext context)
        {
            return  context.Salary* 0.1;
        }


    }
}