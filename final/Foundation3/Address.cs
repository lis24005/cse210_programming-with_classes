public class Address
{
    string _number;
    string _street;
    string _city;
    string _state;
    string _country;
    string _zipcode;
    public Address(string number, string street, string city, string state, string country, string zipcode)
    {
        _number = number;
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _zipcode = zipcode;
    }
    public string GetAddress()
    {
        return $"Address: {_number} {_street}, {_state}, {_country}, {_zipcode}";
    }
}