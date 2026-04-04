using System.Diagnostics.Contracts;

public abstract class Activity
{
    private DateTime _date;
    private float _length;
    public Activity(DateTime date, float minutes)
    {
        _date = date;
        _length = minutes;
    }
    public float GetLength()
    {
        return _length;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public abstract string GetActivityType();
    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType()} ({Math.Round(_length,2)}min) - Distance {Math.Round(GetDistance(), 2)} miles, Speed {Math.Round(GetSpeed(), 2)} mph, Pace {Math.Round(GetPace(), 2)} min per mile";
    }
    
}