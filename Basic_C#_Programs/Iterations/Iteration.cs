using System;
using System.Collections.Generic;

class Iteration
{
    static void Main()
    {
        string text = "";
        string[] namesArray = { "James", "Mario", "Luigi", "Jepetto" };

        Console.WriteLine("Tell me, what game you like to play?");
        text = Console.ReadLine();

        for (int i = 0; i < namesArray.Length; i++)
        {
            Console.WriteLine(namesArray[i] + " also like to play " + text);
        }

        //Fixed loop
        for (int i = 0; i < 10; i++)
        {
            //Console.WriteLine("Infinite");
            //i = 0;
            Console.WriteLine("Not infinite");
        }

        // Loop with '<' operator
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        //A line separator
        Console.WriteLine("\n--------------------------------------\n");

        // Loop with '<=' operator
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\n--------------------------------------\n");
        List<string> fruits = new List<string>();
        fruits.Add("apple");
        fruits.Add("orange");
        fruits.Add("mango");
        fruits.Add("mandarin");
        fruits.Add("banana");
        fruits.Add("blackberry");
        fruits.Add("strawberry");
        fruits.Add("pinaple");
        fruits.Add("pear");
        fruits.Add("kiwi");
        fruits.Add("cherry");

        string textFruit = "";
        Console.WriteLine("Search a fruit in the list containing:");
        textFruit = Console.ReadLine();

        for (int i = 0; i < fruits.Count; i++)
        {
            if (fruits[i].Contains(textFruit))
            {
                Console.WriteLine("Index {0} match with {1}", i, textFruit);
                break;
            }
            else
            {
                Console.WriteLine("There is no fruit match with {0}", textFruit);
            }
        }

        Console.WriteLine("\n--------------------------------------\n");
        List<string> games = new List<string>();
        games.Add("Pokemon");
        games.Add("Digimon");
        games.Add("Borderlands");
        games.Add("Hades");
        games.Add("Tetris");


        string textGames = "";
        Console.WriteLine("Search a game in the list containing:");
        textGames = Console.ReadLine();

        for (int i = 0; i < games.Count; i++)
        {
            if (games[i].Contains(textGames))
            {
                Console.WriteLine("Index: {0}", i);
            }
            else
            {
                Console.WriteLine("There is no game match with index {0}", i);
            }
        }

        //[DEPRECATED]
        //foreach (var game in games)
        //{
        //    if (game.Contains(textGames))
        //    {
        //        Console.WriteLine("INDEX");
        //    }
        //    else
        //    {
        //        Console.WriteLine("There is no game match with {0}", textGames);
        //    }
        //}

        Console.WriteLine("\n--------------------------------------\n");
        List<string> words = new List<string>();
        words.Add("pedro");
        words.Add("looking");
        words.Add("looking");
        words.Add("mustache");
        words.Add("tonight");

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }


        Console.WriteLine("\nPress Enter key to continue...");
        Console.ReadLine();
    }
}