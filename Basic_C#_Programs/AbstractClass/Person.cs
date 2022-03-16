﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayMethod();
    }
}
