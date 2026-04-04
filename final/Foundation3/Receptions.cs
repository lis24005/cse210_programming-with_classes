public class Reception : Event
{
    string _email;
    public Reception(string title, string description, DateTime date, Address address, string email) : base(title, description, date, address)
    {
        _email = email;
    }
    public string GetShortDescription()
    {
        return $"Event type: Reception\n{GetShortDescriptionDetails()}";
    }
    public string GetFullDetails()
    {
        return "Event Type: Reception\n" + GetStandardDetails() + $"\nRSVP Email: {_email}";
    }
}