using System;
using System.Collections.Generic;
using System.Text;
using ValidationEngine.RuleEngine;
using ValidationEngine.Rules;

namespace ValidationEngineConsole.Model
{
    [RuleEngineType(RuleType = typeof(XMLRuleEngine<Registration>))]
    public class Task
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DueWhen { get; set; }
        public bool IsComplete { get; set; }
    }
}
