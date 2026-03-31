using System.Runtime.CompilerServices;

public class Checklist : Goal
{
    int _timesCompleted = 0;
    int _timesToComplete;
    int _bonusPoints;
    public Checklist(string name, string description, int points, int times, int bonus) : base(name, description, points)
    {
        _timesToComplete = times;
        _bonusPoints = bonus;
    }

    public override void DisplayGoal()
    {
        string completed = " ";
        if (GetCompleted())
        {
            completed = "X";
        }
        else { }
        Console.WriteLine($"[{completed}] {GetName()} ({GetDescription()}) -- Currently completed {_timesCompleted}/{_timesToComplete}");
    }
    public override string GetSaveFormat()
    {
        return $"Checklist Goal:{GetName()}^{GetDescription()}^{GetPoints()}^{_bonusPoints}^{_timesToComplete}^{_timesCompleted}";
    }
    public void SetTimesCompleted(int times)
    {
        _timesCompleted = times;
    }

    public override void SetComplete()
    {
        _timesCompleted += 1;
        if (_timesCompleted == _timesToComplete)
        {
            base.SetComplete();
        }
    }
    public override int CalculatePoints()
    {
        int pointsToAdd = _timesCompleted * GetPoints();
        if (_timesCompleted == _timesToComplete)
        {
            pointsToAdd += _bonusPoints;
        }
        return pointsToAdd;

    }
}