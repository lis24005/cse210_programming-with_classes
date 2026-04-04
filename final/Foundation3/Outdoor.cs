public class Outdoor : Event
{
    string _weather;
    public Outdoor(string title, string description, DateTime date, Address address, string weather) : base(title, description, date, address)
    {
        _weather = weather;
    }
    public string GetShortDescription()
    {
        return $"Event type: Outdoor Gathering\n{GetShortDescriptionDetails()}";
    }
    public string GetFullDetails()
    {
        return "Event Type: Outdoor Gathering\n" + GetStandardDetails() + $"\nWeather: {_weather}";
    }
}