using Framework.Contracts.BusinessCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagement.BusinessLogic.OvertimePolicies.OverTimeCalculators.OverTimeCalculatorA
{
    public interface IOverTimeCalculatorA : IBusinessCalculator<OverTimeCalculatorAContext, double>
    {

    }
}
