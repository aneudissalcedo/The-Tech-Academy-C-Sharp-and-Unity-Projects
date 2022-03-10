using System;
using System.Collections.Generic;

class ExceptionHandling
{
    static void Main()
    {
        int dividerNumber = 0;

        List<int> intList = new List<int>();
        intList.Add(24);
        intList.Add(16);
        intList.Add(81);
        intList.Add(36);
        intList.Add(512);

        Console.WriteLine("Below is a list of integers:");
        foreach (var integer in intList)
        {
            Console.WriteLine(integer);
        }

        Console.WriteLine("\nPlease enter a number to divide these numbers in the list:");
        dividerNumber = Convert.ToInt32(Console.ReadLine());

        try
        {
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine("The number {0} divided by {1} is equal to {2}"
                    , intList[i], dividerNumber, (intList[i] / dividerNumber));
            }
        }
        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}