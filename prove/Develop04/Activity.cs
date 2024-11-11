using System.Timers;
public class Activity
{
    protected string _name;
    protected string _description;
    protected string _endMessage;
    protected DateTime _time;
    protected int _duration = 10;
    public Activity(string name, string description, string endMessage, bool startTimer, bool isTimed = true)
    {
        _name = name;
        _description = description;
        _endMessage = endMessage;
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine($"{_description}\n");
        if (isTimed)
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            _duration = int.Parse(Console.ReadLine());
        }
       
        if (startTimer)
        {
            _time = DateTime.Now;
            _time = _time.AddSeconds(_duration);
        }
    }
    public void Pause(bool clear = true, bool pause = true, int duration = 5, int rate = 250)
    {
        if (pause)
        {
            _time = _time.AddSeconds(duration);
        }
        duration = duration * 1000;
        int elapsed = 0;
        if (clear)
        {
            Console.Clear();
        }
        while (elapsed < duration)
        {
            Console.Write("|");
            Thread.Sleep(rate);
            Console.Write("\b \b");
            elapsed += rate;
            Console.Write("/");
            Thread.Sleep(rate);
            Console.Write("\b \b");
            elapsed += rate;
            Console.Write("-");
            Thread.Sleep(rate);
            Console.Write("\b \b");
            elapsed += rate;
            Console.Write("\\");
            Thread.Sleep(rate);
            Console.Write("\b \b");
            elapsed += rate;
        }
    }
    public void Count(bool clear = false, int duration = 5)
    {
        if (clear)
        {
            Console.Clear();
        }
        while (duration > 0)
        {
            Console.Write(duration);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            duration -= 1;
        }
    }
    public void End()
    {
        Console.WriteLine($"You've completed {_duration} seconds of the {_name}.");
        Console.WriteLine(_endMessage);
        Pause(false);
    }
    protected string RandomPrompt(string path)
    {
        Random random = new Random();
        string[] prompts = System.IO.File.ReadAllLines(path);
        return prompts[random.Next(prompts.Length)];
    }
}
class Breathe : Activity
{
    public Breathe(bool clear = true) : base("Breathing Activity", "This activity will help you relax by guiding you through a breathing exercise.", "Good job. Do you feel more relaxed?", true)
    {
        if (clear)
        {
            Console.Clear();
        }
    }
    public void Run()
    {
        DateTime now = DateTime.Now;
        while (now < _time)
        {
            Console.WriteLine("Breathe in...");
            Count();
            Console.WriteLine("Breathe out...");
            Count();
            now = DateTime.Now;
        }
    }
    
}
class Reflect : Activity
{
    public Reflect(bool clear = true) : base("Reflecting Activity", "This activity will help you reflect on your day with guided prompts.", "Good job. How can you make tomorrow even better?", false)
    {
        if (clear)
        {
            Console.Clear();
        }
    }
    string _promptPath1 = "reflect1.txt";
    string _promptPath2 = "reflect2.txt";

    public void Run()
    {
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine("--" + Prompt1() + "--");
        Console.WriteLine("When you have something in mind, press enter to continue. \n");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        Count();
        Console.Clear();
        DateTime now = DateTime.Now;
        _time = now.AddSeconds(_duration);
        while (now < _time)
        {
            Console.WriteLine(Prompt2());
            Count();
            now = DateTime.Now;
        }
    }
    string Prompt1()
    {
        return RandomPrompt(_promptPath1);
    }
    string Prompt2()
    {
        return RandomPrompt(_promptPath2);
    }
}

class Listing : Activity
{
    public Listing(bool clear = true) : base("Listing Activity", "This activity will help you to be mindful.", "Good job. Did you become more aware of something?", false)
    {
        if (clear)
        {
            Console.Clear();
        }
    }
    string _promptPath1 = "list1.txt";
    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("--" + Prompt1() + "--");
        Console.WriteLine("You may begin in: ");
        Count();
        List<string> responses = new List<string>();
        DateTime now = DateTime.Now;
        DateTime _time = now.AddSeconds(_duration);
        while (now < _time)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
            now = DateTime.Now;
        }
        Console.WriteLine($"You listed {responses.Count} items!");
    }
    string Prompt1()
    {
        return RandomPrompt(_promptPath1);
    }
}
class Today : Activity
{
    public Today(bool clear = true) : base("Day Review Activity", "This activity will ask you about your day.", "Good job. What was your favorite part of today?", true, false)
    {
        if (clear)
        {
            Console.Clear();
        }
    }
    public void Run()
    {
        _time = DateTime.Now;
        Console.WriteLine("Did you do a good deed today? What was it?");
        Console.ReadLine();
        Console.WriteLine("Is there anything you need to make amends for?");
        Console.ReadLine();
        Console.WriteLine("What is something you are grateful for today?");
        Console.ReadLine();
        TimeSpan timeSpan = DateTime.Now - _time;
        _duration = (int)timeSpan.TotalSeconds;
    }
}