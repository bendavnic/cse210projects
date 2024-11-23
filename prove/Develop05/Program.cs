using System;

//I didn't have time to do any stretch goals on this assingment.
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager= new GoalManager();
        bool exit = false;

        while(!exit)
        {
            Console.Clear();
            Console.WriteLine("=== Eternal Quest Program ===");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. Record Progress on a Goal");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals to File");
            Console.WriteLine("6. Load Goals from File");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option (1-7): ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal(goalManager);
                    break;
                case "2":
                    RecordProgress(goalManager);
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    Pause();
                    break;
                case "4":
                    goalManager.DisplayScore();
                    Pause();
                    break;
                case "5":
                    SaveGoals(goalManager);
                    break;
                case "6":
                    LoadGoals(goalManager);
                    break;
                case "7":
                    exit = true;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Pause();
                    break;
            }
        }
    }
    static void Pause()
    {
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
    static void CreateGoal(GoalManager goalManager)
    {
        Console.Clear();
        Console.WriteLine("=== Create a Goal ===");
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice (1-3): ");

        string typeChoice = Console.ReadLine();
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                goalManager.AddGoal(new SimpleGoal(name, points));
                break;
            case "2":
                goalManager.AddGoal(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter the target number of completions: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for completing this goal: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                break;
        }
    }
    static void RecordProgress(GoalManager goalManager)
    {
        Console.Clear();
        Console.WriteLine("=== Record Progress ===");
        Console.Write("Enter the name of the goal you accomplished: ");
        string goalName = Console.ReadLine();
        goalManager.UpdateGoal(goalName);
        Pause();
    }
    static void SaveGoals(GoalManager goalManager)
    {
        Console.Clear();
        Console.WriteLine("=== Save Goals ===");
        Console.Write("Enter the file path to save goals: ");
        string filePath = Console.ReadLine() + ".txt";
        goalManager.SaveToFile(filePath);
        Pause();
    }
    static void LoadGoals(GoalManager goalManager)
    {
        Console.Clear();
        Console.WriteLine("=== Load Goals ===");
        Console.Write("Enter the file path to load goals from: ");
        string filePath = Console.ReadLine() + ".txt";
        try
        {
            goalManager.LoadFromFile(filePath);
        }
        catch
        {
            Console.WriteLine("File not found. Loading from last save.");
            goalManager.LoadFromFile();
        }
        Pause();
    }
}