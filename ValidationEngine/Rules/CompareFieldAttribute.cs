using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine.Rules
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class CompareFieldAttribute : ValidationAttribute
    {
        public CompareFieldAttribute() : base()
        {

        }
        public CompareFieldAttribute(string name, string message)
            : base(name, message)
        {
        }

        public override BrokenRule Validate(object value, ValidationContext context)
        {
            BrokenRule rule = new BrokenRule();

            var targetField = context.SourceObject.GetType().GetProperty(this.Name);

            if (value != targetField.GetValue(context.SourceObject))
            {
                rule.IsBroken = true;
                rule.ErrorMessage = this.Message;
                rule.Name = this.Name;
            }

            return rule;
        }
    }
}
