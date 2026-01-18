using System;
using System.Globalization;
class Program
{


    static void Main()
    {

        string name;
        int fav_num;
        int birth_year;
        int fav_num_sqrd;
    

        WelcomeMessage();
        name = GetName();
        fav_num = GetNumber();
        fav_num_sqrd = SquareNumber(fav_num);
        birth_year = GetBirthYear();

        FinalDisplay(name, fav_num_sqrd, birth_year);
    }
    static void WelcomeMessage() {
        Console.WriteLine("Welcome to the program!");
    }
    static string GetName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int GetNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int fav_num) {
        return fav_num * fav_num;
    }
    static int GetBirthYear()
    {
        Console.Write("Please enter your birth year: ");
        return int.Parse(Console.ReadLine());
    }
    static void FinalDisplay(string name, int number_squared, int birthyear){
        Console.WriteLine($"{name}, your favorite number squared is {number_squared}.");
        Console.WriteLine($"{name}, you will turn {DateTime.Now.Year - birthyear} years old");
    }
}