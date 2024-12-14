using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(2022, 11, 3, 25, 3.0),
            new Cycling(2022, 11, 3, 30, 14.0),
            new Swimming(2022, 11, 3, 30, 38)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}