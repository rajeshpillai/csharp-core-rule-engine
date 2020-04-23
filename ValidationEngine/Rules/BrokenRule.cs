﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationEngine.Rules
{
    public class BrokenRule
    {
        public string Name { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsBroken { get; set; }

        public BrokenRule()
        {
            IsBroken = false;
        }
    }
}
