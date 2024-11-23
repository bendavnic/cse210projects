using System.IO;
public class GoalManager
{
    List<Goal> _goals;
    int _score;
    string _fileName = "default.txt";
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine($"Goal '{goal.Name}' added successfully!");
    }
    
    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals added yet.");
            return;
        }
        Console.WriteLine("Your Goals:");
        foreach (var goal in _goals)
        {
            goal.Display();
        }
        DisplayScore();
    }
    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {_score}");
    }
    public void UpdateGoal(string goalName)
    {
        Goal goal = _goals.Find(g => g.Name.Equals(goalName, StringComparison.OrdinalIgnoreCase));
        if (goal != null)
        {
            goal.RecordProgress();
            UpdateScore();
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' was not found.");
        }
    }
    public void UpdateScore()
    {
        int tally = 0;
        foreach(var goal in _goals)
        {
            tally += goal.Points;
        }
        _score = tally;
    }
    public void SaveToFile(string fileName)
    {
        UpdateScore();
        _fileName = fileName;
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName, false))
            {
                writer.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    writer.WriteLine($"{goal.GetType().Name}|{goal.Name}|{goal.PointValue}|{(goal.IsCompleted ? "1" : "0")}" +
                        (goal is ChecklistGoal checklistGoal
                            ? $"|{checklistGoal.CurrentCount}|{checklistGoal.TargetCount}|{checklistGoal.BonusPoints}"
                            : ""));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    public void LoadFromFile()
    {
        LoadFromFile(_fileName);
    }
    public void LoadFromFile(string fileName)
    {
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                _score = int.Parse(reader.ReadLine()); // Read the score

                _goals.Clear(); // Clear existing goals
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string goalType = parts[0];
                    string name = parts[1];
                    int pointValue = int.Parse(parts[2]);
                    bool isCompleted = parts[3] == "1";

                    if (goalType == nameof(SimpleGoal))
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(name, pointValue);
                        if (isCompleted) simpleGoal.RecordProgress(false);
                        _goals.Add(simpleGoal);
                    }
                    else if (goalType == nameof(EternalGoal))
                    {
                        EternalGoal eternalGoal = new EternalGoal(name, pointValue);
                        _goals.Add(eternalGoal);
                    }
                    else if (goalType == nameof(ChecklistGoal))
                    {
                        int currentCount = int.Parse(parts[4]);
                        int targetCount = int.Parse(parts[5]);
                        int bonusPoints = int.Parse(parts[6]);
                        ChecklistGoal checklistGoal = new ChecklistGoal(name, pointValue, targetCount, bonusPoints)
                        {
                            CurrentCount = currentCount
                        };
                        if (isCompleted) checklistGoal.RecordProgress();
                        _goals.Add(checklistGoal);
                    }
                }
            }
            Console.WriteLine("Goals and score loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading from file: {ex.Message}");
        }
    }
}