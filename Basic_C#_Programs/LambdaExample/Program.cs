using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExample
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{FirstName = "Manuel", LastName = "Peña", EmployeeID = 1},
                new Employee{FirstName = "Joe", LastName = "Rodriguez", EmployeeID = 2},
                new Employee{FirstName = "Carmen", LastName = "Garcia", EmployeeID = 3},
                new Employee{FirstName = "Joe", LastName = "Smith", EmployeeID = 4},
                new Employee{FirstName = "Alexa", LastName = "Williams", EmployeeID = 5},
                new Employee{FirstName = "Joe", LastName = "Miller", EmployeeID = 6},
                new Employee{FirstName = "Peter", LastName = "Martinez", EmployeeID = 7},
                new Employee{FirstName = "Ragnar", LastName = "Lothbrok", EmployeeID = 8},
                new Employee{FirstName = "Ivar", LastName = "Lothbrok", EmployeeID = 9},
                new Employee{FirstName = "Mario", LastName = "Mario", EmployeeID = 10}
            };

            foreach (var emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    var newEmployees = emp;
                    Console.WriteLine("ID = " + newEmployees.EmployeeID 
                        + ", " + newEmployees.FirstName + " " + newEmployees.LastName);
                }
            }
            
            Console.WriteLine("\n------------------------------------------");
            var joes = employees.Where(e => e.FirstName == "Joe");

            foreach (var joe in joes)
            {
                Console.WriteLine("ID = " + joe.EmployeeID + ", " + joe.FirstName + " " + joe.LastName);
            }

            Console.WriteLine("\n------------------------------------------");
            var higherEmployees = employees.Where(e => e.EmployeeID > 5);

            foreach (var emp in higherEmployees)
            {
                Console.WriteLine("ID = " + emp.EmployeeID + ", " + emp.FirstName + " " + emp.LastName);
            }

            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}
