using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Contracts.BusinessRule
{
    public class BusinessRuleResult
    {
        public bool Result
        {
            get
            {
                return !(Errors.Count() > 0);
            }
        }

        public List<string> Errors { get; set; } = new List<string>();
    }
}
