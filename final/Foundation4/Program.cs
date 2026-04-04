using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(new DateTime(2026, 9, 15), 20, 3.5));
        activities.Add(new Cycling(new DateTime(2025, 1, 21), 45, 15));
        activities.Add(new Swimming(new DateTime(2023, 11, 27), 15, 20));
        Console.Clear();
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}