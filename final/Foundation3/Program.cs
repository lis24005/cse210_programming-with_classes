using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Lecture myLecture = new Lecture("To be greater", "This presentation will help you be awesome", new DateTime(2026, 10, 15, 8, 30, 0), new Address("5160", "Kymball", "Chubbuck", "Idaho", "USA", "83202"), "Sam", 150);
        Outdoor myOutdoor = new Outdoor("Karaoke Night", "Come sing and have fun with friends while you sing", new DateTime(2026, 11, 5, 8, 0, 0), new Address("742", "Evergreen Terrace", "Springfield", "Illinois", "USA", "62704"), "Overcast");
        Reception myReception = new Reception("The Justins", "A reception for the wedding of Jenn and Henry Justin", new DateTime(2026, 12, 1, 6, 45, 0), new Address("1600", "Amphitheatre Parkway", "Mountain View", "California", "USA", "94043"), "jenn+henry@gmail.com");
        Console.WriteLine(myLecture.GetShortDescription() + "\n");
        Console.WriteLine(myLecture.GetStandardDetails() + "\n");
        Console.WriteLine(myLecture.GetFullDetails() + "\n");
        Console.WriteLine(myOutdoor.GetShortDescription() + "\n");
        Console.WriteLine(myOutdoor.GetStandardDetails() + "\n");
        Console.WriteLine(myOutdoor.GetFullDetails() + "\n");
        Console.WriteLine(myReception.GetShortDescription()+"\n");
        Console.WriteLine(myReception.GetStandardDetails()+"\n");
        Console.WriteLine(myReception.GetFullDetails()+"\n");
    }
}