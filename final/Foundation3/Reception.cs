public class Reception : Event
{
    string _RSVPEmail;
    public Reception (string email, string title, string description, int year, int month, int day, int hour, int minute, Address address = null) : base (title, description, year, month, day, hour, minute, address)
    {
        _RSVPEmail = email;
    }
    public override string FullDetails()
    {
        return base.FullDetails() + $"\nRSVP Email: {_RSVPEmail}";
    }
    public override string ShortDescription()
    {
        return base.ShortDescription();
    }
}