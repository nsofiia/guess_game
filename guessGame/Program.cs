using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(101);
            int closePlus = randomNumber + 5;
            int closeMinus = randomNumber - 5;
            int guess = 0;
            int wrongGuessCount = 3;
            Console.WriteLine("Hello Traveler!");
            //Console.WriteLine(randomNumber);
            while (wrongGuessCount != 0)
            {
                Console.WriteLine("Guess a number I have on my mind from 1 to 100\n" +
                        $"You have {wrongGuessCount} wrong answers before the game ends: ");
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("this input is not supported, enter only numbers");
                    continue;
                }
                if (randomNumber == guess)
                {
                    Console.WriteLine("you win, number of guesses refreshed!");
                    wrongGuessCount = 3;
                    continue;
                }
                if (randomNumber > guess)
                {
                    if (guess > closeMinus & guess < closePlus)
                    {
                        Console.WriteLine("You're close!");
                        wrongGuessCount++;
                    }
                    Console.WriteLine("too low");
                    wrongGuessCount--;
                }
                if (randomNumber < guess)
                {
                    if (guess > closeMinus && guess < closePlus)
                    {
                        Console.WriteLine("You're close!");
                        wrongGuessCount--;
                    }
                    Console.WriteLine("too high");
                    wrongGuessCount--;
                }
            }
            Console.WriteLine("guessed wrong 3 times, you lost, game over");
            Console.ReadKey(true);
        }

    }
}