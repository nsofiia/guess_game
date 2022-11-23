using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumberGenerator = new Random();
            double randomNumber = randomNumberGenerator.Next(100);
            double closePlus = randomNumber + 5;
            double closeMinus = randomNumber - 5;
            for (int wrongGuesses = 0; wrongGuesses < 3; wrongGuesses++)
            {
                Console.WriteLine("Hello Traveler! Can you guess a number I have on my mind from 1 to 100?\n" +
                        "Enter number and press enter, you can have only 3 wrong answers: ");
                double guess = Convert.ToDouble(Console.ReadLine());

                if (randomNumber == guess)
                {
                    Console.Write("you win");
                    break;
                }
                if (randomNumber > guess)
                {
                    Console.WriteLine("too high");
                    if (guess == closeMinus || guess == closePlus)
                    {
                        Console.WriteLine("You're close!");
                        wrongGuesses++;
                    }
                }
                if (randomNumber < guess)
                {
                    Console.WriteLine("too low");
                    if (guess == closeMinus || guess == closePlus)
                    {
                        Console.WriteLine("You're close!");
                        wrongGuesses++;
                    }
                }

            }
            Console.WriteLine("guessed wrong 3 times, you lost, game over");
            Console.ReadKey(true);
        }

    }
}