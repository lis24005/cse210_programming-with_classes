using System;
using System.ComponentModel.Design;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Hello Develop03 World!");
        Library library = new Library();


        Reference ref1 = new Reference("1");
        Book book1 = new Book("Lion King", ref1);
        library.AddBook(book1);

        Reference ref2 = new Reference("2");
        Book book2 = new Book("The Birds", ref2);
        library.AddBook(book2);
        */
        bool run = true;
        Word word = new Word();
        Reference reference = new Reference();
        Scripture scripture = new Scripture();
        int initialChoice;
        Console.WriteLine("What scripture would you like to memorize? (input the number before the scripture)\n" +
                        "1:Proverbs 3:5-6\n" +
                        "2:John 3:16\n" +
                        "3:Write your own");
        initialChoice = int.Parse(Console.ReadLine());
        if (initialChoice == 1)
        {
            reference.SetReference("Proverbs", 3, 5, 6);
            scripture.ScriptureToWords("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        }
        else if (initialChoice == 2)
        {
            reference.SetReference("John", 3, 16);
            scripture.ScriptureToWords("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        }
        else if (initialChoice == 3)
        {
            Console.WriteLine("What is the book?");
            string book = Console.ReadLine();
            Console.WriteLine("What is the chapter?");
            int chapter = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the starting verse?");
            int verse1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the final? (If your scripture is only one verse input 'none')");
            string verse2 = Console.ReadLine();
            if (verse2 == "none")
            {
                reference.SetReference(book, chapter, verse1);
            }
            else
            {
                reference.SetReference(book, chapter, verse1, int.Parse(verse2));
            }
            Console.WriteLine("What is the text of your scripture?");
            scripture.ScriptureToWords(Console.ReadLine());
        }
        while (run)
        {
            Console.Clear();
            Console.WriteLine(reference.GetDisplayReference() + " " + scripture.GetDisplayScripture());
            Console.WriteLine("Press 'enter' to continue, or input 1 to end.");
            string input = Console.ReadLine();
            if (input == "1")
            {
                run = false;
            }
            else
            {
                if (scripture.CheckAllWordsHidden())
                {
                    Console.WriteLine("All words are hidden, press 'enter'");
                    Console.ReadLine();
                    run = false;
                }
                else
                {
                    scripture.HideWords();
                }
            }
            
        }
    }
}