using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadMethod
{
    public class OverloadMethod
    {
        public void DivideMethod(int a)
        {
            a = a / 2;
            Console.WriteLine(a);
        }

        public void GetValue(out int a)
        {
            int temp = 5;
            a = temp;
        }

        public void ValueOverload(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void ValueOverload(float a, float b)
        {
            Console.WriteLine(a + b);
        }

        public void ValueOverload(string a, string b)
        {
            Console.WriteLine(a + " " + b);
        }
    }
}
