using System;

namespace Polymorphism
{
    class Program
    {
        static void Main()
        {
            IQuittable quittable = new Employee();

            quittable.Quit();

            Console.WriteLine("\nPress Enter Key to continue...");
            Console.ReadLine();
        }
    }
}
