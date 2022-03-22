using System;

namespace EnumExample
{
    class Program
    {
        enum WeekDays
        {
            monday, tuesday, wednesday, thursday, friday, saturday, sunday
        }

        static void Main()
        {
            string userInput = "";
            WeekDays weekDays;

            Console.WriteLine("Please enter the current day of the week:");
            userInput = Console.ReadLine().ToLower();

            try
            {
                weekDays = (WeekDays)Enum.Parse(typeof(WeekDays), userInput);
                Console.WriteLine("Today is {0}", weekDays);
            }
            catch(Exception ex)
            {
                Console.WriteLine("\nPlease enter an actual day of the week.");
                Console.WriteLine(ex.Message);
            }



            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}
