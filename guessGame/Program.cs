using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        const int MAX_GUESSES = 3;

        static void Main(string[] args)
        {
            while (true)
            {
                int wrongGuessCount = MAX_GUESSES;
                Random randomNumberGenerator = new Random();
                int randomNumber = randomNumberGenerator.Next(101);
                int closePlus = randomNumber + 5;
                int closeMinus = randomNumber - 5;
                int absolute = Math.Abs(closePlus - closeMinus);
                // Console.WriteLine(absolute);
                Console.WriteLine("Hello Traveler!");
                // Console.WriteLine(randomNumber);

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
                        if (guess >= closeMinus && guess <= closePlus)
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
                        string answer = "0";
                        Console.WriteLine($"GAME OVER --- guessed wrong {MAX_GUESSES} times" +
                            "\n Would you like to star over? y - to start over; n - to exit ");

                        while (answer == "0")
                        {
                            answer = Console.ReadLine().ToLower();
                        }

                        if (answer == "y")
                        {
                            break;
                        }
                        else
                        {
                            System.Environment.Exit(1);
                        }
                    }
                }
            }
        }
    }
}

