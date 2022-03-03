using System;

class MathComparisonOperators
{
    static void Main()
    {
        //Declaration of variables for person 1
        int person1HourlyRate = 0;
        int person1HoursPerWeek = 0;
        int person1AnnualSalary = 0;

        //Declaration of variables for person 2
        int person2HourlyRate = 0;
        int person2HoursPerWeek = 0;
        int person2AnnualSalary = 0;

        Console.WriteLine("Anonymous Income Comparison Program\n");
        
        //Section for person 1
        Console.WriteLine("Person 1:");
        Console.WriteLine("Hourly Rate?");
        person1HourlyRate = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hours worked per week?");
        person1HoursPerWeek = Convert.ToInt32(Console.ReadLine());

        //Section for person 2
        Console.WriteLine("Person 2:");
        Console.WriteLine("Hourly Rate?");
        person2HourlyRate = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hours worked per week?");
        person2HoursPerWeek = Convert.ToInt32(Console.ReadLine());

        //Calculation of annual salaries for both person 1 and person 2
        person1AnnualSalary = person1HourlyRate * person1HoursPerWeek * 52;
        person2AnnualSalary = person2HourlyRate * person2HoursPerWeek * 52;

        Console.WriteLine("Annual salary of Person 1:\n{0}", person1AnnualSalary);
        Console.WriteLine("Annual salary of Person 2:\n{0}", person2AnnualSalary);

        Console.WriteLine("Does Person 1 make more money than Person 2?\n{0}", person1AnnualSalary > person2AnnualSalary);
    }
}