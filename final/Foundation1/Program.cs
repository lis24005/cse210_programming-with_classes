using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Video video1 = new Video("Cooking", "Jonny", "3:34");
        video1.AddComment(new Comment("Steven", "That looks good!"));
        video1.AddComment(new Comment("Elizabeth", "I will have to try that soon"));
        video1.AddComment(new Comment("James", "I am lactose intolerant"));
        Video video2 = new Video("Gaming", "Alex", "10:12");
        video2.AddComment(new Comment("Chris", "This game looks awesome!"));
        video2.AddComment(new Comment("Morgan", "What level is this?"));
        video2.AddComment(new Comment("Taylor", "I got stuck here too"));
        Video video3 = new Video("Workout", "Sam", "6:45");
        video3.AddComment(new Comment("Jordan", "Great routine!"));
        video3.AddComment(new Comment("Casey", "I felt the burn!"));
        video3.AddComment(new Comment("Riley", "Can you make a beginner version?"));
        video1.DisplayVideo();
        video2.DisplayVideo();
        video3.DisplayVideo();
    }
}