using System;

namespace SuperClassMethod
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            
            employee.SayName();

            Console.WriteLine("\nPress Enter Key to continue...");
            Console.ReadLine();
        }
    }
}
