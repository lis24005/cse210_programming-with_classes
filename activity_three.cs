using System.Diagnostics.CodeAnalysis;
Random randomGenerator = new Random();

int magic_number = randomGenerator.Next(1, 101);
string user_guess_indicator = "fail";
int user_guess;

while (user_guess_indicator == "fail")
{
    Console.Write("What is your guess? ");
    user_guess = int.Parse(Console.ReadLine());
    if (user_guess == magic_number)
    {
        user_guess_indicator = "correct";
    }
    else if (user_guess > magic_number)
    {
        Console.WriteLine("Incorrect guess, the magic number is lower");
    }
    else if (user_guess < magic_number)
    {
        Console.WriteLine("Incorrect guess, the magic number is higher.");
    }
}

Console.WriteLine("Corrrect!");
