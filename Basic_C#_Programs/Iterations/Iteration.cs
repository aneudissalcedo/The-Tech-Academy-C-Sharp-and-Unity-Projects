using System;
using System.Linq;
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
            //Console.WriteLine(namesArray[i] + " also like to play " + text);
            namesArray[i] = namesArray[i] + " also like to play " + text;
            Console.WriteLine(namesArray[i]);
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

        //Part 5: This one is missing. A list of strings that has at least 
        //    two identical strings in the list. Ask the user to select text 
        //    to search for in the list. This one iterates like in part 4 
        //    but there are two identical strings and you print out those indexes if chosen.

        List<string> games = new List<string>();
        games.Add("pokemon is a catching creature monster game.");
        games.Add("digimon is a digital creature monster game.");
        games.Add("borderlands has a funny story main line.");
        games.Add("hades, one of the newest game in the market place.");
        games.Add("tetris is a classic game.");

        string textGames = "";
        int selection = 0;
        //Console.WriteLine("Search a game in the list containing:");
        //textGames = Console.ReadLine();
        do
        {
            Console.WriteLine("Select a text to search in the list:");
            Console.WriteLine("1)creature \n2)funny \n3)monster \n4)classic \n5)market");
            selection = Convert.ToInt32(Console.ReadLine());

        } while (selection <= 0 || selection > 5);

        switch(selection)
        {
            case 1:
                textGames = "creature";
                break;
            case 2:
                textGames = "funny";
                break;
            case 3:
                textGames = "monster";
                break;
            case 4:
                textGames = "classic";
                break;
            case 5:
                textGames = "market";
                break;
        }

        //var duplicateGames = games
        //        .GroupBy(x => x)
        //        .Where(g => g.Count() > 1)
        //        .Select(g => g.Key);

        for (int i = 0; i < games.Count; i++)
        {
            if (games[i].Contains(textGames))
            {
                //Console.WriteLine(games[i] + " is a duplicate with index {0}", i);
                Console.WriteLine("The word {0} is in the index: {1}", textGames, i);
            }
            else
            {
                //Console.WriteLine("There is no duplicate game with index {0}", i);
                Console.WriteLine("The word {0} is not in the index: {1}", textGames, i);
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

        //Part 6: You just iterate through the list and print all the values out. 
        //In this one you need to create a foreach loop that evaluates each item 
        //in the list, and displays a message showing the string and whether or not 
        //it has already appeared in the list.

        List<string> words = new List<string>();
        List<string> duplicates = new List<string>();
        words.Add("pedro");
        words.Add("looking");
        words.Add("looking");
        words.Add("mustache");
        words.Add("tonight");

        foreach (var word in words)
        {
            if (duplicates.Contains(word))
            {
                Console.WriteLine(word + " already appeared in the list.");
            }
            else
            {
                Console.WriteLine(word + " first time in the list.");
                duplicates.Add(word);
            }
        }


        Console.WriteLine("\nPress Enter key to continue...");
        Console.ReadLine();
    }
}