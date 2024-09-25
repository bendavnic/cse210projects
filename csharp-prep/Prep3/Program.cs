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
            int magicnumber = random.Next(1, 100);
            int guess = 0;
            int guesscount = 0;
            Console.WriteLine("Guess the magic number!");
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guesscount ++;
                if (guess > magicnumber)
                {
                    Console.WriteLine("Lower...");
                }
                else if (guess < magicnumber)
                {
                    Console.WriteLine("Higher...");
                }
                else
                {
                    Console.WriteLine($"You guessed the magic number in {guesscount} tries!");
                }
            } while (guess != magicnumber);
            Console.Write("Want to play again? ");
            play = Console.ReadLine();
        }while (play == "yes");
    }
}