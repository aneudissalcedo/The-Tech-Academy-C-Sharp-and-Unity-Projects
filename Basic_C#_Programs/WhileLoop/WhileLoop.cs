using System;

class WhileLoop
{
    static void Main()
    {
        int x = 1;

        while (x < 20)
        {
            Console.WriteLine("X is equal to: {0}", x);
            x++;
        }
        Console.ReadLine();
    }
}
