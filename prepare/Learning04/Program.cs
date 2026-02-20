using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Learning04 World!");
        MathAssignment mathassignment = new MathAssignment("Section 1", "5-6", "James", "Math 310");
        WritingAssignment writingassignment = new WritingAssignment("John", "English 120", "Western Stories");
        Console.WriteLine(mathassignment.GetSummary());
        Console.WriteLine(mathassignment.GetHomeworkList());
        Console.WriteLine(writingassignment.GetWritingAssignment());

    }
}