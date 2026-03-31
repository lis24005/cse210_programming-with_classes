public class Eternal : Goal
{
    int _timesCompleted = 0;
    public Eternal(string name, string description, int points) : base(name, description, points) { }
    public override string GetSaveFormat()
    {
        return $"Eternal Goal:{GetName()}^{GetDescription()}^{GetPoints()}^{_timesCompleted}";
    }
    public void SetTimesCompleted(int times)
    {
        _timesCompleted = times;
    }
    public override void SetComplete()
    {
        _timesCompleted += 1;
    }
    public override int CalculatePoints()
    {
        return  GetPoints() * _timesCompleted;
    }
}