using System.Collections.Generic;
using Framework.Contracts.BusinessRule;

namespace Framework.Exceptions;

public class BusinessRuleException : Exception
{
    public BusinessRuleException() : base("invalid operation")
    {
        Errors = new List<string>();
    }
    public BusinessRuleException(List<string> errors) : this()
    {
        Errors = errors;
    }


    public BusinessRuleException(BusinessRuleResult result) : this()
    {
        Result = result;
        Errors = result.Errors;
    }

    public BusinessRuleResult Result { get; }

    public List<string> Errors { get; }
}
