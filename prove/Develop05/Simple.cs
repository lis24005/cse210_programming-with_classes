public class Simple : Goal
{
    public Simple(string name, string description, int points) : base(name, description, points) { }
    public override string GetSaveFormat()
    {
        return $"Simple Goal:{GetName()}^{GetDescription()}^{GetPoints()}^{GetCompleted()}";
    }
    public override int CalculatePoints()
    {
        if (GetCompleted())
        {
            return GetPoints();
        }
        return 0;
    }
    
}