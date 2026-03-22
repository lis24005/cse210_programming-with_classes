using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    double _side = 6;
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
    
}