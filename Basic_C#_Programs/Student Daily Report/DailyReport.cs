using System;

class DailyReport
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy.");
        Console.WriteLine("Student Daily Report.\n");

        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();

        Console.WriteLine("What page number?");
        int page = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
        bool isTrue = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Were there any positive experiences you?d like to share? Please give specifics.");
        string positiveExperience = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you?d like to provide? Please be specific.");
        string feedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        int hours = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
    }
}