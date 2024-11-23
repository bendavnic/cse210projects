public abstract class Goal
{
    protected string _name;
    protected int _pointTotal;
    protected int _pointValue;
    protected bool _isCompleted;
    //DateTime _Created;
    public Goal(string name, int points)
    {
        _name = name;
        _pointValue = points;
        _isCompleted = false;
    }
    public abstract void RecordProgress(bool display = true);
    public virtual string GetStatus()
    {
        return _isCompleted ? "[X]" : "[ ]";
    }
    public int Points
    {
        get { return _pointTotal; }
    }
    public int PointValue
    {
        get { return _pointValue; }
    }
    public string Name
    {
        get { return _name; }
    }
    public bool IsCompleted
    {
        get { return _isCompleted; }
    }
    public virtual void Display()
    {
        Console.WriteLine($"{_name} {GetStatus()}");
    }
}