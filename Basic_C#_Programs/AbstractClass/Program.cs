using System;

namespace AbstractClass
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            employee.SayMethod();

            Console.WriteLine("\nPress Enter Key to continue...");
            Console.ReadLine();
        }
    }
}
