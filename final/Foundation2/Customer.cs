using System.Runtime.CompilerServices;

public class Customer
{
    private string _customerName;
    private Address _address;
    List<Product> products = new List<Product>();
    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }
    public string GetCustomerName()
    {
        return _customerName;
    }
    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }
    public bool IsUSA()
    {
        return _address.IsUSA();
    }

}