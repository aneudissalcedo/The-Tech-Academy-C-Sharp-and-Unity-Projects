using System;

class Loops
{
    static void Main()
    {
        int x = 1;
        int y = 1;

        Console.WriteLine("While Loop:");
        while (x < 20)
        {
            Console.WriteLine("X is equal to: {0}", x);
            x++;
        }

        Console.WriteLine("\nDo While Loop:");
        do
        {
            Console.WriteLine("Y is equal to: {0}", y);
            y++;
        } while (y < 20);

        Console.ReadLine();
    }
}
