using System;
using System.Collections.Generic;
using System.Text;

namespace VoidMethod
{
    public class VoidMethod
    {
        public void VoidMethodIntegers(int a = 0, int b = 0)
        {
            b = b + a + 5;
            Console.WriteLine(b);
        }
    }
}
