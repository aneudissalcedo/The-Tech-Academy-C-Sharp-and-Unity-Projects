using System;
using System.Collections.Generic;

namespace TwoParametersMethod
{
    class Program
    {
        static void Main()
        {
            Addition addition = new Addition();
            int a;
            string b;

            Console.WriteLine("Please enter a number to apply an addition operation (01):");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You can add an additional number to apply the operation, " +
                "but its optional (Just press the 'Enter' key to continue if dont want to add" +
                "an additional number:");
            b = Console.ReadLine();

            if (b == "")
            {
                Console.WriteLine("Result of ({0} + {0}): {1}", a, addition.AdditionIntegers(a));
            }
            else
            {
                int x;
                x = Convert.ToInt32(b);
                Console.WriteLine("Result of ({0} + {0} + {1}): {2}", a, b, addition.AdditionIntegers(a, x));
            }

            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}
