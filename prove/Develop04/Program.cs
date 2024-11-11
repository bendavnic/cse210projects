using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = Menu();
        while (userChoice < 5)
        {
            switch (userChoice)
            {
                case 0:
                    userChoice = Menu();
                    break;
                case 1:
                    Breathe breathe= new Breathe();
                    Console.WriteLine("Get Ready...");
                    breathe.Pause(false);
                    breathe.Run();
                    breathe.End();
                    userChoice = 0;
                    break;
                case 2:
                    Reflect reflect = new Reflect();
                    Console.WriteLine("Get Ready...");
                    reflect.Pause(false);
                    reflect.Run();
                    reflect.End();
                    userChoice = 0;
                    break;        
                case 3:
                    Listing listing = new Listing();
                    Console.WriteLine("Get Ready...");
                    listing.Pause(false);
                    listing.Run();
                    listing.End();
                    userChoice = 0;
                    break;
                case 4:
                    Today today = new Today();
                    Console.WriteLine("Get Ready...");
                    today.Pause(false);
                    today.Run();
                    today.End();
                    userChoice = 0;
                    break;
                case 5:
                    break;
            }
        }
    }
    public static int Menu(bool clear = true)
    {
        if (clear)
        {
            Console.Clear();
        }
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Start Breathing Activity");
        Console.WriteLine("\t2. Start Reflecting Activity");
        Console.WriteLine("\t3. Start Listing Activity");
        Console.WriteLine("\t4. Start Day Review Activity");
        Console.WriteLine("\t5. Quit");
        Console.Write("Select a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }
}