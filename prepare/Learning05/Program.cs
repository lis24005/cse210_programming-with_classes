using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        /*Square square = new Square("red", 3);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());
        Circle circle = new Circle("blue", 9);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
        Rectangle rectangle = new Rectangle("pink", 3, 4);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());*/
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("red", 3);
        Circle circle = new Circle("blue", 9);
        Rectangle rectangle = new Rectangle("pink", 5, 4);
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        foreach(Shape shape in shapes) {
        Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}"); 
        }

    }
}