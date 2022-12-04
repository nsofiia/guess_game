using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        const int MAX_GUESSES = 3;
        const int CLOSE_GUESS = 5;

        static void Main(string[] args)
        {
            Random randomNumberGenerator = new Random();
            while (true)
            {
                int wrongGuessCount = MAX_GUESSES;
                int randomNumber = randomNumberGenerator.Next(1, 101);
                Console.WriteLine("Hello Traveler!");
                //Console.WriteLine(randomNumber);

                while (wrongGuessCount != 0)
                {
                    Console.WriteLine("Guess a number from 1 to 100\n" +
                        $"You have {wrongGuessCount} wrong answers before the game ends: ");
                    int guess = 101;

                    while (guess > 100 || guess < 1)
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
                        int guessOffset = Math.Abs(randomNumber - guess);
                        //Console.WriteLine(guessOffset + " guessOffset ---");

                        if (guessOffset <= CLOSE_GUESS)
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

