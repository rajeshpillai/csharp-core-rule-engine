using System;
using System.Collections.Generic;
using System.Text;
using ValidationEngine.RuleEngine;
using ValidationEngine.Rules;

namespace ValidationEngineConsole.Model
{
    [RuleEngineType(RuleType = typeof(DefaultRuleEngine<Registration>))]
    public class Registration
    {
        [RequiredField("UserName", "User name cannot be empty")]
        [MaxLenField("UserName", "Max 15 chars", 15)]
        public string UserName { get; set; }

        public string Password { get; set; }

        [RequiredField("Email", "Email cannot be empty")]
        public string Email { get; set; }

        [CompareField("Email", "Email is not the same")]
        public string EmailConfirm { get; set; }
    }
    
}
