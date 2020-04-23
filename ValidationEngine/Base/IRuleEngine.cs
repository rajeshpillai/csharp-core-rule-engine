using System;
using System.Collections.Generic;
using System.Text;
using ValidationEngine.Rules;

namespace ValidationEngine.RuleEngine
{
    public interface IRuleEngine<T>
    {
        List<BrokenRule> Validate(T value);
    }
}
