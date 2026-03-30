using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Order order1 = new Order(new Customer("John", new Address("2112 Hiline", "Pocatello", "Idaho", "USA")));
        order1.AddToProducts(new Product("PaperClips", 1302, 0.25, 17));
        order1.AddToProducts(new Product("Pencils", 1287, 1.25, 4));
        order1.AddToProducts(new Product("Stapeler", 1299, 5.99, 1));
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"\nPacking Label: \n{order1.GetPackingLabel()}");
        Console.WriteLine(order1.GetTotalCost());
        Console.WriteLine();
        Order order2 = new Order(new Customer("Emily", new Address("221B Baker Street", "London", "Greater London", "UK")));
        order2.AddToProducts(new Product("Notebook", 2105, 2.50, 6));
        order2.AddToProducts(new Product("Markers", 2140, 3.75, 3));
        order2.AddToProducts(new Product("Binder", 2199, 7.25, 2));
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"\nPacking Label: \n{order2.GetPackingLabel()}");
        Console.WriteLine(order2.GetTotalCost());
    }
}