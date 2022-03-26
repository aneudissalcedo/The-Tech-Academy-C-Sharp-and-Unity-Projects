using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace DateTimeExample
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("\nPlease enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("In {0} hours, the time will be: {1}", number, DateTime.Now.AddHours(number));

            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}
