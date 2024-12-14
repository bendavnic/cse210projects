public class Activity
{
    protected DateTime _date;
    protected int _duration;
    public Activity(int year, int month, int day, int duration)
    {
        _date = new DateTime(year, month, day);
        _duration = duration;
    }
     public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy}: {this.GetType().Name} ({_duration} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kmph, Pace: {GetPace():F2} min/km";
    }
}