using System;

class Branching
{
    static void Main()
    {
        int weight = 0;
        int width = 0;
        int height = 0;
        int length = 0;
        int dimensions = 0;
        int quote = 0;

        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");
        Console.WriteLine("Please enter the package weight:");
        weight = Convert.ToInt32(Console.ReadLine());

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }
        else
        {
            Console.WriteLine("Please enter the package width:");
            width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            length = Convert.ToInt32(Console.ReadLine());

            dimensions = width * height * length;

            if (dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            quote = (dimensions * weight) / 100;

            Console.WriteLine("Your estimated total for shipping this package is: ${0}", quote + ".00");
            Console.WriteLine("Thank you!");
        }
    }
}