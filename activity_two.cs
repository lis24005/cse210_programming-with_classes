using System.Data.Common;
using System.Reflection;
string grade_letter = "";
Console.Write("What is the grade you would like to input? ");
float grade_percent = float.Parse(Console.ReadLine());

if (grade_percent >= 90.0f)
{
    grade_letter = "A";
}
else if (grade_percent >= 80f)
{
    grade_letter = "B";
}
else if (grade_percent >= 70f)
{
    grade_letter = "C";
}
else if (grade_percent >= 60f)
{
    grade_letter = "D";
}
else if (grade_percent >= 50f)
{
    grade_letter = "f";
}
else
{
    Console.WriteLine("Your Score doesn't merit a letter grade");
}

if (grade_percent >= 50)
{
    Console.WriteLine($"You got a(n) {grade_letter}");
}

if (grade_letter == "A" || grade_letter == "B" || grade_letter == "C")
{
    Console.WriteLine("You passed!");
}
else
{
    Console.WriteLine("You did not pass.");
}