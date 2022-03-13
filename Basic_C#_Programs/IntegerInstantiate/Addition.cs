using System;
using System.Collections.Generic;
using System.Text;

namespace IntegerInstantiate
{
    public class Addition
    {
        public int AdditionIntegers(int a)
        {
            a += a;
            return a;
        }

        public int AdditionIntegers(decimal a)
        {
            a -= a;
            return Convert.ToInt32(a);
        }

        public int AdditionIntegers(string s)
        {
            int a;
            a = Convert.ToInt32(s);
            a *= a;

            return a;
        }
    }
}
