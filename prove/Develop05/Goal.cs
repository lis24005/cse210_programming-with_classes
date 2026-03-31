public abstract class Goal
{
    string _goalName;
    string _description;
    int _points;
    bool _completed = false;
    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _description = description;
        _points = points;
    }
    public virtual void SetComplete()
    {
        _completed = true;
    }
    public virtual void DisplayGoal()
    {
        string completed;
        if (_completed)
        {
            completed = "X";
        }
        else
        {
            completed = " ";
        }
        Console.WriteLine($"[{completed}] {_goalName} ({_description})");
    }
    public abstract string GetSaveFormat();
    public string GetName()
    {
        return _goalName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public bool GetCompleted()
    {
        return _completed;
    }
    public abstract int CalculatePoints();
    
}