using System.Dynamic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

public class Event
{
    string _title;
    string _description;
    string _date;
    string _time;
    Address _address;
    public Event(string title, string description, DateTime date, Address address)
    {
        _title = title;
        _description = description;
        _date = date.ToString("dd MMM yyyy");
        _time = date.ToString("HH:mm");
        _address = address;
    }
    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetAddress()}";
    }
    public string GetShortDescriptionDetails()
    {
        return $"Title: {_title}\nDate: {_date}";
    }
}