using System;
using System.Collections.Generic;

namespace OverloadMethod
{
    class Program
    {
        static void Main()
        {
            OverloadMethod overloadMethod = new OverloadMethod();
            int a = 0;

            Console.WriteLine("Please enter a number to be divide it by 2:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n{0} divide it by 2 is equal to", a);
            overloadMethod.DivideMethod(a);

            Console.WriteLine("\nBefore the method call, value of a: {0}", a);
            overloadMethod.GetValue(out a);
            Console.WriteLine("After the method call, value of a: {0}\n", a);

            Console.WriteLine("Interger overload:");
            overloadMethod.ValueOverload(4, 2);
            Console.WriteLine("Float overload:");
            overloadMethod.ValueOverload(5f, 2f);
            Console.WriteLine("String overload:");
            overloadMethod.ValueOverload("John", "Doe");

            var result = MiniCalculator.Sum(13, 3);
            MiniCalculator.Store(result);
            Console.WriteLine("\nMiniCalculator sum result: {0}", result);

            Console.WriteLine("\nPress Enter Key to continue...");
            Console.ReadLine();
        }
    }
}
