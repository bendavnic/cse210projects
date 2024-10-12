using System;

class Program
{
    static void Main(string[] args)
    {
        //menu
        int choice = 0;
        Journal journal = new Journal();
        while (choice != 3)
        {
            Console.WriteLine("Welcome to your Journal. Choose an option:\n1. Write a new entry\n2. Load journal entries \n3. Exit your journal");
            while (choice == 0)
            {
                try
                    {
                        choice = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please choose by entering a number.");
                    }
            }
            while (choice == 1)
            {
                //gets a random prompt and then gets a journal entry from the user
                Prompt prompt = new Prompt();
                journal.NewEntry(prompt.message());
                choice = 0;
            }
            while (choice == 2)
            {
                List<Entry> entries = journal.GetEntries(File.read(Journal.path));
                journal.DisplayJournal(entries);
                choice = 0;
            }
        }
    }
}

public class Journal
{
    public static string path = "save.txt";
    public void DisplayJournal(List<Entry> journal, int count = -1)
    {
        if (count == -1 || count > journal.Count)
        {
            foreach (Entry entry in journal)
            {
                Console.WriteLine($"{entry.dateTime}: \"{entry.response}\"");
            }
        }
        else
        {
            Entry entry = journal[count - 1];
            Console.WriteLine($"{entry.dateTime}: \"{entry.response}\"");
        }
    }
    public void NewEntry(string prompt)
    {
        Console.WriteLine("Write your journal entry. Here's a prompt to help you:");
        Console.WriteLine(prompt);
        Entry entry = new Entry();
        entry.response = Console.ReadLine();
        File.write(entry, path);
    }
    public List<Entry> GetEntries(string[] text)
    {
        List<Entry> entries = new List<Entry>();
        foreach(string s in text)
        {
            string[] x = s.Split("^");
            Entry entry = new Entry();
            entry.dateTime = x[0];
            entry.response = x[1];
            entries.Add(entry);
        }

        return entries;
    }
}

public class File
{
    public static string[] read(string path)
    {
        string[] lines = System.IO.File.ReadAllLines(path);
        return lines;
    }
    public static void write(Entry entry, string filePath)
    {
        using (StreamWriter output = new StreamWriter(filePath, true))
        {
            output.WriteLine(entry.dateTime + "^" + entry.response);
        }
    }
}
public class Entry
{
    public string dateTime = DateTime.Today.ToShortDateString();
    public string response;
}

public class Prompt
{
    public static string path = "prompts.txt";
    public string message()
    {
        Random random = new Random();
        try
        {
            string[] prompts = File.read(path);
            return prompts[random.Next(prompts.Length)];
        }
        catch (Exception)
        {
            return "What did you learn from reading the scriptures today?";
        }
        
    }
}