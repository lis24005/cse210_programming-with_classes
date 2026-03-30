public class Product
{
    private string _name;
    private int _productID;
    private double _pricePerUnit;
    private int _quantity;
    public Product(string name, int productID, double pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }
    public double GetProductPrice()
    {
        return _pricePerUnit * _quantity;
    }
    public string GetProductName()
    {
        return _name;
    }
    public int GetProductID()
    {
        return _productID;
    }
}