using System.Runtime.CompilerServices;

public class FileManager
{
    public void SaveGoals(string filename, List<Goal> goals, int totalPoints)
    {
        List<string> lines = new List<string>();
        lines.Add($"TotalPoints:{totalPoints.ToString()}");
        foreach (Goal goal in goals)
        {
            lines.Add(goal.GetSaveFormat());
        }
        File.WriteAllLines(filename, lines);
    }
    public List<Goal> LoadGoals(string filename, out int totalPoints)
    {
        List<Goal> goals = new List<Goal>();
        totalPoints = 0;
        if (!File.Exists(filename))
        {
            Console.WriteLine("There is no file with that name, make sure to add .txt to your file search.");
            return goals;
        }
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            if (line.StartsWith("TotalPoints:"))
            {
                totalPoints = int.Parse(line.Split(":")[1]);
            }
            else
            {
                Goal goal = RetrieveGoals(line);
                if (goal != null)
                {
                    goals.Add(goal);
                }
            }
        }
        return goals;
    }
    public Goal RetrieveGoals(string line)
    {
        string[] parts = line.Split(":");
        if (parts.Length < 2)
        {
            return null;
        }
        string goalType = parts[0];
        string[] goalData = parts[1].Split("^");
        if (goalType == "Checklist Goal")
        {
            string name = goalData[0];
            string description = goalData[1];
            int points = int.Parse(goalData[2]);
            int bonusPoints = int.Parse(goalData[3]);
            int timesToComplete = int.Parse(goalData[4]);
            int timesCompleted = int.Parse(goalData[5]);
            Checklist goal = new Checklist(name, description, points, timesToComplete, bonusPoints);
            goal.SetTimesCompleted(timesCompleted);
            return goal;
        }
        else if (goalType == "Simple Goal")
        {
            string name = goalData[0];
            string description = goalData[1];
            int points = int.Parse(goalData[2]);
            bool completed = bool.Parse(goalData[3]);
            Simple goal = new Simple(name, description, points);
            if (completed)
            {
                goal.SetComplete();
            }
            return goal;

        }
        else if (goalType == "Eternal Goal")
        {
            string name = goalData[0];
            string description = goalData[1];
            int points = int.Parse(goalData[2]);
            int timesCompleted = int.Parse(goalData[3]);
            Eternal goal = new Eternal(name, description, points);
            goal.SetTimesCompleted(timesCompleted);
            return goal;
        }
        return null;
    }
}