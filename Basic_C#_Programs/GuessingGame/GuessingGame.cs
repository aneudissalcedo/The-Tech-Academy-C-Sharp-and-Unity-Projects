using System;

class GuessingGame
{
    static void Main()
    {
        Random random = new Random();
        //random.Next(minValue, maxValue) takes as parameters a minimum and maximum range of numbers...
        //...The random number is between 1 and less than max value (in this case 10)
        int randomNumber = random.Next(1, 11);
        int guessNumber = 0;
        int attempt = 3;
        bool isNumber = false;
        bool playAgain = false;

        Console.WriteLine("Do you like games? I want to play a game with you.");

        do
        {
            Console.WriteLine("I'm thinking a number between 1 to 10, can you guess what number it is?");
            randomNumber = random.Next(1, 11);
            isNumber = false;
            attempt = 3;

            while (attempt > 0 && isNumber == false)
            {
                Console.WriteLine("Your guess number:");
                guessNumber = Convert.ToInt32(Console.ReadLine());

                if (guessNumber == randomNumber)
                {
                    Console.WriteLine("Congratulations, you guessed the correct number!");
                    isNumber = true;
                }
                else
                {
                    Console.WriteLine("Wrong number, Better luck next time!");
                    attempt -= 1;

                    if (attempt > 0)
                        Console.WriteLine("You have {0} attempt left.", attempt);
                }
            }

            Console.WriteLine("\nDo you want to play again?(y/n)");
            switch(Console.ReadLine().ToLower())
            {
                case "y":
                    playAgain = true;
                    break;
                case "n":
                    playAgain = false;
                    break;
            }

        } while (playAgain == true);

        Console.WriteLine("\nThank you for playing!");
        Console.ReadLine();
    }
}