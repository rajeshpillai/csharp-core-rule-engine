using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using ValidationEngine.Rules;

namespace ValidationEngine.RuleEngine
{
    public static class RuleEngineFactory<T> where T : class
    {
        public static IRuleEngine<T> GetEngine()
        {
            string configurationString = ConfigurationManager.AppSettings["RuleEngineType"];

            string ruleType = "ValidationEngine.RuleEngine." + configurationString + "`1";
            var d1 = Type.GetType(ruleType); 
            Type[] typeArgs = { typeof(T) };

            var makeme = d1.MakeGenericType(typeArgs);
            var o = (IRuleEngine<T>)Activator.CreateInstance(makeme);
            

            return o;
            
        }
    }
}
