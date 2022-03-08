using System;
using System.Collections.Generic;

class ArrayAndList
{
    static void Main()
    {
        int numberSelection = 0;

        //String Array Section
        //----------------------
        string[] stringArray = new string[3];
        stringArray[0] = "Easy";
        stringArray[1] = "Normal";
        stringArray[2] = "Hard";

        Console.WriteLine("Select a difficulty mode:");
        do
        {
            Console.WriteLine("1: {0}\n2: {1}\n3: {2}", stringArray[0], stringArray[1], stringArray[2]);
            numberSelection = Convert.ToInt32(Console.ReadLine());
            if (numberSelection > stringArray.Length || numberSelection <= 0)
            {
                Console.WriteLine("*WARNING*: The Selected number is out of range.");
                Console.WriteLine("Please, select an available difficulty mode:");
            }

        } while (numberSelection > stringArray.Length || numberSelection <= 0);

        Console.WriteLine("Difficulty selected: {0}", stringArray[numberSelection - 1]);

        //Int Array Section
        //----------------------
        int[] intArray = new int[3];
        intArray[0] = 3;
        intArray[1] = 11;
        intArray[2] = 27;

        Console.WriteLine("\nSelect a number between 0 to 2:");
        do
        {
            Console.WriteLine("1: {0}\n2: {1}\n3: {2}", intArray[0], intArray[1], intArray[2]);
            numberSelection = Convert.ToInt32(Console.ReadLine());
            if (numberSelection > intArray.Length || numberSelection <= 0)
            {
                Console.WriteLine("*WARNING*: The Selected number is out of range.");
                Console.WriteLine("Please, select an available index:");
            }
        } while (numberSelection > intArray.Length || numberSelection <= 0);
        Console.WriteLine("Index selected: {0}", intArray[numberSelection - 1]);

        //List Section
        //----------------------
        List<string> stringList = new List<string>();
        stringList.Add("Expert");
        stringList.Add("Master");
        stringList.Add("Torment");

        Console.WriteLine("\nSelect a new difficulty mode:");
        do
        {
            Console.WriteLine("1: {0}\n2: {1}\n3: {2}", stringList[0], stringList[1], stringList[2]);
            numberSelection = Convert.ToInt32(Console.ReadLine());
            if (numberSelection > stringList.Count || numberSelection <= 0)
            {
                Console.WriteLine("*WARNING*: The Selected number is out of range.");
                Console.WriteLine("Please, select one of the new available difficulty mode:");
            }

        } while (numberSelection > stringList.Count || numberSelection <= 0);

        Console.WriteLine("Difficulty selected: {0}", stringList[numberSelection - 1]);

        Console.ReadLine();
    }
}