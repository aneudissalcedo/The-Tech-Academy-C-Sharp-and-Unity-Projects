using System;

namespace GenericExample
{
    class Program
    {
        static void Main()
        {
            Employee<string> employeeString = new Employee<string>();
            employeeString.AddProperty("First");
            employeeString.AddProperty("Second");
            employeeString.AddProperty("Third");

            Employee<int> employeeInt = new Employee<int>();
            employeeInt.AddProperty(1);
            employeeInt.AddProperty(2);
            employeeInt.AddProperty(3);

            employeeString.PrintAllThings();
            employeeInt.PrintAllThings();

            Console.WriteLine("\nPress Enter Key to continue...");
            Console.ReadLine();
        }
    }
}
