public class Breathing : Activity
{
    int _breathCycleCount;
    public Breathing(string welcome, int timer, string thankyou, int breathCycleCount) : base(welcome, timer, thankyou)
    {
        _breathCycleCount = breathCycleCount;
    }
    public static int GetBreathCycleCount(int time)
    {
        return time / 10;
    }
    public void BreathCycleDisplay()
    {
        Console.Write("\nBreath in: ");
        for (int i = 5; i >= 0; i--)
        {
            Console.Write($"{i,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.Write("\nBreath out: ");
        for (int i = 5; i >= 0; i--)
        {
            Console.Write($"{i,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
    }
}