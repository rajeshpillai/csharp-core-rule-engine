﻿using System;
using ValidationEngine.RuleEngine;
using ValidationEngineConsole.Model;

namespace ValidationEngineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Registration register = new Registration();

            IRuleEngine<Registration> ruleEngine = RuleEngineFactory<Registration>.GetEngine();

            register.UserName = "";
            register.Password = "test123";
            register.Email = "";
            register.EmailConfirm = "test";

            var results = ruleEngine.Validate(register);

            foreach (var r in results)
            {
                if (r.IsBroken)
                {
                    Console.WriteLine("{0} rule is broken and the error is {1}", r.Name, r.ErrorMessage);
                }
            }

            Console.Read();
        }
    }
}
