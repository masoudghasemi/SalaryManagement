using System.Collections.Generic;
using System.Linq;

namespace Framework.Contracts.BusinessRule
{
    public interface BusinessRule<TObject> where TObject : class
    {
        public BusinessRuleResult Check(TObject entity);

    }

}
