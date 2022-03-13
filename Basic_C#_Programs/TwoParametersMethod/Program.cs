using System;
using System.Collections.Generic;

namespace TwoParametersMethod
{
    class Program
    {
        static void Main()
        {
            Addition addition = new Addition();
            int a = 0;
            int b = 0;

            Console.WriteLine("Please enter a number to apply an addition operation (01):");
            a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("You can add an additional number to apply the operation, " +
            //    "but its optional (Just press the 'Enter' key to continue if dont want to add" +
            //    "an additional number:");
            Console.WriteLine("You can add an additional number to apply the operation:");
            b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Result of ({0} + {0} + {1}): {2}", a, b, addition.AdditionIntegers(a, b));

            Console.WriteLine("\nPlease enter a number to apply an addition operation (02, not using the optional number):");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result of ({0} + {0}): {1}", a, addition.AdditionIntegers(a));

            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}
