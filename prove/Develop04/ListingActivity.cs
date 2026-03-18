using System.Threading.Tasks.Dataflow;

public class Listing : Activity
{
    string _prompt;

    public Listing(string welcome, int timer, string thankyou, string prompt) : base(welcome, timer, thankyou)
    {
        _prompt = prompt;
    }
    public static string GetPrompt()
    {
        List<string> prompts = new List<string>
        {"Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"};
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        return prompt;
    }
    public void SilentCountDown()
    {
        Thread.Sleep(1000);
    }
}