using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        int userGuess;
        List<int> guesses = new List<int>();

        do
        {
            Console.WriteLine("Enter your guess (1-100):");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out userGuess))
            {
                if (guesses.Contains(userGuess))
                {
                    int index = guesses.IndexOf(userGuess);
                    int turnsAgo = guesses.Count - index;
                    Console.WriteLine($"You guessed this number {turnsAgo} turns ago!");
                }
                else
                {
                    guesses.Add(userGuess);

                    if (userGuess == randomNumber)
                    {
                        Console.WriteLine("Congratulations! You guessed the correct number.");
                    }
                    else if (userGuess > randomNumber)
                    {
                        Console.WriteLine("Your guess is too high. Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Your guess is too low. Try again.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
            }
        } while (userGuess != randomNumber);

        Console.WriteLine($"You Won! The answer was {randomNumber}.");
    }
}