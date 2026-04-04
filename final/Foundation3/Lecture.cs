public class Lecture : Event
{
    string _speaker;
    int _capacity;
    public Lecture(string title, string description, DateTime date, Address address, string speaker, int capacity) : base(title, description, date, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetShortDescription()
    {
        return $"Event type: Lecture\n{GetShortDescriptionDetails()}";
    }
    public string GetFullDetails()
    {
        return "Event Type: Lecture\n" + GetStandardDetails() + $"\nSpeaker: {_speaker}\nCapacity: {_capacity} ";
    }
}