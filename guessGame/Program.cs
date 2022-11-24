using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int wrongGuessCount = 3;
                Random randomNumberGenerator = new Random();
                int randomNumber = randomNumberGenerator.Next(101);
                int closePlus = randomNumber + 5;
                int closeMinus = randomNumber - 5;
                Console.WriteLine("Hello Traveler!");
                Console.WriteLine(randomNumber);
                while (wrongGuessCount != 0)
                {
                    Console.WriteLine("Guess a number from 1 to 100\n" +
                        $"You have {wrongGuessCount} wrong answers before the game ends: ");
                    int guess = 0;
                    while (guess == 0)
                    {
                        try
                        {
                            guess = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("this input is not supported, enter only numbers from 1 to 100");
                            continue;
                        }
                    }
                    if (guess != randomNumber)
                    {
                        if (guess >= closeMinus & guess <= closePlus)
                        {
                            Console.WriteLine("You're close!");
                        }
                        if (guess < randomNumber)
                        {
                            Console.WriteLine("too low");
                        }
                        if (guess > randomNumber)
                        {
                            Console.WriteLine("too high");
                        }
                        wrongGuessCount--;
                    }
                    else
                    {
                        Console.WriteLine("WIN --- number of guesses refreshed!...starting over");
                        break;
                    }
                }
                Console.WriteLine("GAME OVER --- guessed wrong 3 times");
                Console.ReadKey(true);
                break;
            }
        }
    }
}

