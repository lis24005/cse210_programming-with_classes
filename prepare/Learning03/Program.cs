using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction myfraction = new Fraction();

        myfraction.SetBottom(1);
        myfraction.SetTop(1);
        Console.WriteLine(myfraction.GetFraction());
        Console.WriteLine(myfraction.GetDecimal().ToString("F2"));

        myfraction.SetBottom(1);
        myfraction.SetTop(5);
        Console.WriteLine(myfraction.GetFraction());
        Console.WriteLine(myfraction.GetDecimal().ToString("F2"));

        myfraction.SetBottom(4);
        myfraction.SetTop(3);
        Console.WriteLine(myfraction.GetFraction());
        Console.WriteLine(myfraction.GetDecimal().ToString("F2"));

        myfraction.SetBottom(3);
        myfraction.SetTop(1);
        Console.WriteLine(myfraction.GetFraction());
        Console.WriteLine(myfraction.GetDecimal().ToString("F2"));

        myfraction.Random20();
    }
}