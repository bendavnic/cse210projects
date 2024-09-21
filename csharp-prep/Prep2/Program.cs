using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage grade did you get in the class? ");
        string userInput = Console.ReadLine();
        int userGrade = int.Parse(userInput);

        string gradeLetter = "";
        if (userGrade >= 90)
        {
            gradeLetter = "A";
        }
        else if (userGrade >= 80)  
        {
            gradeLetter = "B";
        }
        else if (userGrade >= 70)
        {
            gradeLetter = "C";
        }
        else if (userGrade >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        int remainder = userGrade % 10;
        string gradeMod = "";
        if (remainder >= 7 && !(gradeLetter == "A" || gradeLetter == "F"))
        {
            gradeMod = "+";
        }
        else if (remainder < 3 && gradeLetter != "F")
        {
            gradeMod = "-";
        }

        Console.WriteLine($"You got an {gradeLetter}{gradeMod}.");
        if (userGrade >= 70)
        {
            Console.WriteLine("You passed! Congratulations.");
        }
        else
        {
            Console.WriteLine("You failed! Study harder next time.");
        }
    }
}