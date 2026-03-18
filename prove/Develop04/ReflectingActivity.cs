using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Reflecting : Activity
{
    string _prompt;
    public Reflecting(string welcome, int timer, string thankyou, string prompt) : base(welcome, timer, thankyou)
    {
        _prompt = prompt;
    }
    public static string GetPrompt()
    {
        List<string> prompts = new List<string>
        {"Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        return prompt;
    }
    public string GetQuestion()
    {
        List<string> questions = new List<string>
        {"Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"};
        Random rand = new Random();
        string question = questions[rand.Next(questions.Count)];
        return question;
    }
    public int GetPromptCount(int time)
    {
        return time / 10;
    }
}