using System.Collections.Generic;
using System.Linq;

namespace Framework.Contracts.BusinessCalculator
{
    public interface IBusinessCalculator<TContext,TResult> where TContext : class
    
    {
        public  TResult Calculate(TContext context);

    }

}
