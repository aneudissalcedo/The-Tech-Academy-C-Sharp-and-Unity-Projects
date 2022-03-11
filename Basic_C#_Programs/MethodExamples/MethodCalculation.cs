using System;
using System.Collections.Generic;
using System.Text;

namespace MethodExamples
{
    public class MethodCalculation
    {
        public int SumInt(int a)
        {
            a += a;
            return a;
        }

        public int SubInt(int a)
        {
            a -= a;
            return a;
        }

        public int MultInt(int a)
        {
            a *= a;
            return a;
        }
    }
}
