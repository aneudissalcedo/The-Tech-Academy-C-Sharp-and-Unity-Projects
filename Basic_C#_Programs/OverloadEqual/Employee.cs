using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadEqual
{
    public class Employee : Person
    {
        public int EmployeeID { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.EmployeeID == employee2.EmployeeID;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.EmployeeID != employee2.EmployeeID;
        }

    }
}
