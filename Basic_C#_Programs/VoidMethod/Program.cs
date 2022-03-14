using System;
using System.Collections.Generic;

namespace VoidMethod
{
    class Program
    {
        static void Main()
        {
            VoidMethod voidMethod = new VoidMethod();
            int firstInteger = 3;
            int secondInteger = 7;

            voidMethod.VoidMethodIntegers(a: firstInteger, b: secondInteger);

            Console.WriteLine("\nPress Enter Key to continue...");
            Console.ReadLine();
        }
    }
}
