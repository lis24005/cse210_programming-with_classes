using System.Diagnostics;

public class Activity
{
    string _welcome;
    int _timer;
    string _thankyou;
    public Activity(string welcome, int timer, string thankyou)
    {
        _welcome = welcome;
        _timer = timer;
        _thankyou = thankyou;
    }
    public void ShowSpinner()
    {
        Console.Write("/");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(250);
        Console.Write("\b \b");
    }
    public void ShowTimer(int time) {
        for (int i = time; i >= 0; i--)
        {
            Console.Write($"{i,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
    }
    public void DisplayWelcome() {
        Console.WriteLine(_welcome);
    }
    public void DisplayThankYou() {
        Console.WriteLine(_thankyou);
    }
}