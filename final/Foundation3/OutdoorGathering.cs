public class OutdoorGathering : Event
{
    string _forecast;
    public OutdoorGathering (string forecast, string title, string description, int year, int month, int day, int hour, int minute, Address address = null) : base (title, description, year, month, day, hour, minute, address)
    {
        _forecast = forecast;
    }
    public override string FullDetails()
    {
        return StandardDetails() + $"\nEvent Type: Outdoor Gathering\nWeather Forecast: {_forecast}";
    }
    public override string ShortDescription()
    {
        return $"Outdoor Gathering: {_title} on {_dateTime.ToShortDateString()}";
    }
}