using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endyear;

    public void Display()
    {
        Console.WriteLine($"{_company}, {_jobTitle}, {_startYear} - {_endyear}");
    }
}