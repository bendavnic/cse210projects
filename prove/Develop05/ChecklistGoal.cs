public class ChecklistGoal : Goal
{
    int _currentCount;
    public int CurrentCount
    {
        get { return _currentCount; }
        set { _currentCount = value; }
    }
    int _targetCount;
    public int TargetCount
    {
        get { return _targetCount; }
    }
    int _bonusPoints;
    public int BonusPoints
    {
        get { return _bonusPoints; }
    }
    public ChecklistGoal(string name, int points, int goal): base(name, points)
    {
        _currentCount = 0;
        _targetCount = goal;
        _bonusPoints = _pointValue * _targetCount;
    }
    public ChecklistGoal(string name, int points, int goal, int bonus) : base(name, points)
    {
        _currentCount = 0;
        _targetCount = goal;
        _bonusPoints = bonus;
    }
    public override void RecordProgress(bool display = true)
    {
        if (!_isCompleted)
        {
            _currentCount ++;
            if (display)
            {
                Console.WriteLine($"Progress made on '{_name}'. You earned {_pointValue} points!");
            }
            _pointTotal += _pointValue;
            if (_currentCount == _targetCount)
            {
                _isCompleted = true;
                if (display)
                {
                    Console.WriteLine($"Goal '{_name}' completed! A bonus {_bonusPoints} points have been awarded!");
                }
                _pointTotal += _bonusPoints;
            }
        }
        else
        {
            if (display)
            {
                Console.WriteLine($"Goal '{_name}' is already completed!");
            }
        }
    }
    public override string GetStatus()
    {
        return $"{base.GetStatus()} Completed {_currentCount}/{_targetCount} times";
    }
}