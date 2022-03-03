using System;

class BooleanLogic
{
    static void Main()
    {
        int age = 0;
        bool dui = false;
        int tickets = 0;

        Console.WriteLine("What is your age?");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Have you ever had a DUI?");
        dui = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("How many speeding tickets do you have?");
        tickets = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Qualified?\n{0}", age > 15 && dui == false && tickets <= 3 );
    }
}