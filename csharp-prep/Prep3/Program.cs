using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string play = "";
        do
        {
            int magicNumber = random.Next(1, 100);
            int guess = 0;
            int guessCount = 0;
            Console.WriteLine("Guess the magic number!");
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount ++;
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower...");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher...");
                }
                else
                {
                    Console.WriteLine($"You guessed the magic number in {guessCount} tries!");
                }
            } while (guess != magicNumber);
            Console.Write("Want to play again? ");
            play = Console.ReadLine();
        }while (play == "yes");
    }
}