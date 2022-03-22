using System;

namespace OverloadEqual
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.EmployeeID = 1;
            employee2.EmployeeID = 1;

            if (employee1 == employee2)
            {
                Console.WriteLine("Employee 1 is equal to Employee 2", employee1, employee2);
            }
            else 
            {
                Console.WriteLine("Employee 1 is not equal to Employee 2", employee1, employee2);
            }

            Console.WriteLine("\nPress Enter Key to continue...");
            Console.ReadLine();
        }
    }
}
