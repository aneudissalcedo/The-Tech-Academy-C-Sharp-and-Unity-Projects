using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadMethod
{
    public static class MiniCalculator
    {
        private static int resultStorage = 0;

        public static int Sum(int a, int b)
        {
            return (a + b);
        }

        public static void Store(int result)
        {
            resultStorage = result;
        }
    }
}
