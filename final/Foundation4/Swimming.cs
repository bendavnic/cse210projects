public class Swimming : Activity
{
    private int _laps;

    public Swimming(int year, int month, int day, int minutes, int laps) : base(year, month, day, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * 50 / 1000.0;
    public override double GetSpeed() => GetDistance() / _duration * 60;
    public override double GetPace() => _duration / GetDistance();
}