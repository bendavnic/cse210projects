public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points)
    {
    }
    public override void RecordProgress(bool display = true)
    {
        if (display)
        {
            Console.WriteLine($"Goal '{_name}' completed! You earned {_pointValue} points!");
        }
        
        _isCompleted = true;
        _pointTotal += _pointValue;
    }
}