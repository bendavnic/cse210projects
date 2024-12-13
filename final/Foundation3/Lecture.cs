public class Lecture : Event
{
    string _speaker;
    int _capacity;
    public Lecture (string speaker, int capacity, string title, string description, int year, int month, int day, int hour, int minute, Address address = null) : base (title, description, year, month, day, hour, minute, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string FullDetails()
    {
        return base.FullDetails() + $"\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
    public override string ShortDescription()
    {
        return base.ShortDescription();
    }
}