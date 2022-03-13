using System;
using System.Collections.Generic;

namespace IntegerInstantiate
{
    class Program
    {
        static void Main()
        {
            Addition addition = new Addition();
            int a = 5;
            decimal b = 5m;
            string s = "7";

            Console.WriteLine("Passing in an integer: " + addition.AdditionIntegers(a));
            Console.WriteLine("Passing in a decimal: " + addition.AdditionIntegers(b));
            Console.WriteLine("Passing in a decimal: " + addition.AdditionIntegers(s));

            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}
