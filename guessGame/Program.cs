using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        const int MAX_GUESSES = 3;
        const int closeGuess = 5;

        static void Main(string[] args)
        {
            while (true)
            {
                int wrongGuessCount = MAX_GUESSES;
                Random randomNumberGenerator = new Random();
                int randomNumber = randomNumberGenerator.Next(1, 101);
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

                    int guessOffset = Math.Abs(randomNumber - guess);
                    //Console.WriteLine(guessOffset + " guessOffset ---");

                    if (guess != randomNumber)
                    {
                        if (guessOffset <= closeGuess)
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

                    if (wrongGuessCount == 0)
                    {
                        Console.WriteLine($"GAME OVER --- guessed wrong {MAX_GUESSES} times" +
                            "\nWould you like to star over? y - to start over; n - to exit ");

                        string answer = Console.ReadLine().ToLower();

                        if (answer == "y")
                        {
                            break;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}

