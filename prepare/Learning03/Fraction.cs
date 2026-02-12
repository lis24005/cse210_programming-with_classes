using System.Globalization;

public class Fraction
{
    private int _top;
    private int _bottom;

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetTop(int number)
    {
        _top = number;
    }

    public void SetBottom(int number)
    {
        _bottom = number;
    }

    public string GetFraction()
    {
        return $"{_top}/{_bottom}";
    }
    public float GetDecimal()
    {
        float outcomeDecimal = (float)_top / _bottom;
        return outcomeDecimal;
    }

    public void Random20()
    {
        Random random = new Random();
        for (int i = 1; i <= 20; i++)
        {
            _top = random.Next(1, 10);
            _bottom = random.Next(1, 10);
            Console.WriteLine(GetFraction());
            Console.WriteLine(GetDecimal().ToString("F2"));
        }
    }
}