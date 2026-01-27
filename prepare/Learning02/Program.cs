using System;
using Microsoft.VisualBasic;

public class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Ford";
        job1._jobTitle = "Foreman";
        job1._startYear = 2000;
        job1._endyear = 2010;
        Console.WriteLine($"{job1._company} {job1._jobTitle}");

        Job job2 = new Job();
        job2._company = "Chevy";
        job2._jobTitle = "Engineer";
        job2._startYear = 1990;
        job2._endyear = 2005;
        Console.WriteLine($"{job2._company} {job2._jobTitle}");

        Resume resume = new Resume();
        resume._name = "Caitlin Lish";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}