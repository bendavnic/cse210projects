using System.Diagnostics.Contracts;

public class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _dateTime;
    protected Address _address;

    public Event (string title, string description, int year, int month, int day, int hour, int minute, Address address = null)
    {
        _title = title;
        _description = description;
        _dateTime = new DateTime(year, month, day, hour, minute, 0);
        _address = address;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
    virtual public string StandardDetails()
    {
         string addressDetails = _address != null ? _address.ToString() : "Address: Not provided";
        return $"Title: {_title}\nDescription: {_description}\nDate: {_dateTime.ToShortDateString()}\nTime: {_dateTime.ToShortTimeString()}\n{addressDetails}";
    }
    virtual public string FullDetails()
    {
        // for the base class, this is the same as StandardDetails()
        return StandardDetails() + $"\nEvent Type: {GetType().Name}";
    }
    virtual public string ShortDescription()
    {
        return $"{GetType().Name}: {_title} on {_dateTime.ToShortDateString()}";
    }
}