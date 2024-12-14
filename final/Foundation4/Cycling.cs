public class Cycling : Activity
{
    private double _speed;

    public Cycling(int year, int month, int day, int minutes, double speed) : base(year, month, day, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance() => (_speed * _duration) / 60;
    public override double GetSpeed() => _speed;
    public override double GetPace() => _duration / GetDistance();
}