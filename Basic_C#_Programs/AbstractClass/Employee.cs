using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee : Person
    {
        public override void SayMethod()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
    }
}
