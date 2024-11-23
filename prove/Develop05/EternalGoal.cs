public class EternalGoal : Goal
{
    int _currentCount;
    public EternalGoal(string name, int points) : base(name, points)
    {
        _currentCount = 0;
    }
    public override void RecordProgress(bool display = true)
    {
        if (display)
        {
            Console.WriteLine($"Progress made on '{_name}'. You earned {_pointValue} points!");
        }
        _isCompleted = true;
        _currentCount ++;
        _pointTotal = _pointValue * _currentCount;
    }
    public override string GetStatus()
    {
        return $"{base.GetStatus()} Completed {_currentCount} times";
    }
}