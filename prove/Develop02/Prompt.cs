using System;
public class Prompt
{
    List<string> prompts = new List<string>{
    "Write about your day in detail.",
    "Describe a place where you feel most at peace.",
    "What is something you’re grateful for today?",
    "Recall a happy memory from childhood.",
    "Write about a challenge you overcame recently.",
    "Describe your favorite hobby and why you love it.",
    "Write about someone who inspires you.",
    "If you could travel anywhere, where would you go and why?",
    "Describe a goal you have for this year.",
    "Write about a book or movie that changed your perspective.",
    "Reflect on a lesson you learned the hard way.",
    "Describe your perfect day from morning to night.",
    "Write a letter to your future self.",
    "Describe a fear you’ve overcome or want to overcome.",
    "Write about a time you helped someone else.",
    "Describe your favorite meal and why it’s special.",
    "Write about a moment when you felt proud of yourself.",
    "Reflect on a mistake and what it taught you.",
    "Describe someone you miss and why.",
    "Write about a dream you hope to achieve in the next 5 years."};
    private Random rand = new Random();

    public string GeneratePrompt()
    {
        int random_number = rand.Next(0, prompts.Count);
        return prompts[random_number];
    }
}