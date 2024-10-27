using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        bool hidden = false;
        string path = "scriptures.txt";
        Scripture scripture = new Scripture(Scripture.Get(path));
        Console.Clear();
        string user = "";
        while (hidden == false && user.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.Out());
            hidden = scripture.Hide(4);
            Console.WriteLine("\nPress enter to continue, or type \"quit\" to finish:");
            user = Console.ReadLine();
        }
    }
}