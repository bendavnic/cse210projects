public class Running : Activity
{
    private double _distance;

    public Running(int year, int month, int day, int minutes, double distance) : base(year, month, day, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => _distance / _duration * 60;
    public override double GetPace() => _duration / _distance;
}