
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorA;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorB;
using SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorC;
using SalaryManagement.BusinessLogic.OvertimePolicies.TaxCalculators.TaxCalculator;

namespace SalaryManagement.BusinessLogic.OvertimePolicies.SalaryCalculators.SalaryCalculator
{
    public  class SalaryCalculator  : ISalaryCalculator
    {
        
        private readonly IOverTimeCalculatorA _overTimeCalculatorA;
        private readonly IOverTimeCalculatorB _overTimeCalculatorB;
        private readonly IOverTimeCalculatorC _overTimeCalculatorC;
        private  readonly  ITaxCalculator _taxCalculator;

        public SalaryCalculator(
            IOverTimeCalculatorA overTimeCalculatorA,
            IOverTimeCalculatorB overTimeCalculatorB,
            IOverTimeCalculatorC overTimeCalculatorC,
            ITaxCalculator taxCalculator
        )
        {
            _overTimeCalculatorA = overTimeCalculatorA;
            _overTimeCalculatorB = overTimeCalculatorB;
            _overTimeCalculatorC = overTimeCalculatorC;
            _taxCalculator = taxCalculator;
        }

        public virtual  double Calculate(SalaryCalculatorContext context)
        {
            double salary = context.BasicSalary + context.Allowance + context.Transportation;

            switch (context.OverTimeCalculator)
            {
                case "OverTimeCalculatorA":
                    salary += _overTimeCalculatorA.Calculate(new OverTimeCalculatorAContext()
                        { BasicSalary = context.BasicSalary ,Allowance = context.Allowance,OverTimeMinutes = context.OverTimeMinutes});
                    break;

                case "OverTimeCalculatorB":
                    salary += _overTimeCalculatorB.Calculate(new OverTimeCalculatorBContext()
                        { BasicSalary = context.BasicSalary, Allowance = context.Allowance, OverTimeMinutes = context.OverTimeMinutes });
                    break;

                case "OverTimeCalculatorC":
                    salary += _overTimeCalculatorC.Calculate(new OverTimeCalculatorCContext()
                        { BasicSalary = context.BasicSalary, Allowance = context.Allowance, OverTimeMinutes = context.OverTimeMinutes });
                    break;
                
                default:
                    throw  new Exception("invalid calculator");
            }
            
            var tax =  _taxCalculator.Calculate(new TaxCalculatorContext()
            {
                Salary = salary
            });

            var finalSalary = salary - tax;

            return  finalSalary;

        }


    }
}