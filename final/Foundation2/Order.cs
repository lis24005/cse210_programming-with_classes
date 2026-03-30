using System.Reflection.Emit;

public class Order
{
    private Customer _customer;
    List<Product> products = new List<Product>();
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddToProducts(Product product)
    {
        products.Add(product);
    }
    public string GetShippingLabel()
    {
        return $"Name:{_customer.GetCustomerName()}\n{_customer.GetFullAddress()}";
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += $"Product Name: {product.GetProductName()}\nProduct ID: {product.GetProductID()}\n";
        }
        return packingLabel;
    }
    public string GetTotalCost()
    {
        double price = 0;
        bool usa = _customer.IsUSA();
        foreach (Product product in products)
        {
            price += product.GetProductPrice();
        }
        if (usa) {
        price += 5;
        }
        else
        {
            price += 35;
        }
        return $"Total Cost: ${Math.Round(price,2)}";
    }

}
