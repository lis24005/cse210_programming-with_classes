using System;
using System.Data.Common;
using System.IO.Compression;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        int reflectingCount = 0;
        int breathingCount = 0;
        int listingCount = 0;
        string start = "";
        while (start == ""){
            Console.Clear();
            Console.WriteLine("You have done " + reflectingCount + " reflecting activities");
            Console.WriteLine("You have done " + listingCount + " listing activities");
            Console.WriteLine("You have done " + breathingCount + " breathing activities");
            Console.WriteLine("What Type of actvity would you like to do?\n1: Reflecting\n2: Listing\n3:Breathing\n(Please enter the number coorelated with the activity you'd like to do)");
            string decision = Console.ReadLine();
            if (decision == "1")
            {
                string welcome = "Welcome to the reflecting activity, in this activity you will given a prompt and will be given a question every 10 seconds related to the prompt to think about.";
                string thankyou = "Well done!!!\n\nThankyou for doing the reflecting activity, you may press enter to do another activity or enter any key to end.";
                Console.WriteLine("How much time would you like to spend on the activity? Please enter an integer that is a multiple of 10(10, 20, 30, etc)");
                int time = int.Parse(Console.ReadLine());
                while (time % 10 != 0)
                {
                    Console.Write("That is not a multiple of ten, please try again: ");
                    time = int.Parse(Console.ReadLine());
                }
                string prompt = Reflecting.GetPrompt();
                Reflecting myReflecting = new Reflecting(welcome, time, thankyou, prompt);
                myReflecting.DisplayWelcome();
                Console.WriteLine("Your Prompt is: " + prompt);
                Console.Write("Get ready, your activity starts in: ");
                myReflecting.ShowTimer(10);
                int promptCount = myReflecting.GetPromptCount(time);
                for (int i = 0; i < promptCount; i++)
                {
                    Console.WriteLine("\n" + myReflecting.GetQuestion());
                    for (int x = 5; x > 0; x--)
                    {
                        myReflecting.ShowSpinner();
                    }
                }
                Console.WriteLine();
                myReflecting.DisplayThankYou();
                reflectingCount += 1;
                start = Console.ReadLine();
            }
            else if (decision == "2")
            {
                string welcome = "Welcome to the listing activity, in this activity you will given a prompt and will have the oppurtunity to enter as many responses as you would like.";
                string thankyou = "Well done!!!\n\nThankyou for doing the listing activity, you may press enter to do another activity or enter any key to end.";
                Console.WriteLine("How much time would you like to spend on the activity? Please enter an integer that is a multiple of 10(10, 20, 30, etc)");
                int time = int.Parse(Console.ReadLine());
                while (time % 10 != 0)
                {
                    Console.Write("That is not a multiple of ten, please try again: ");
                    time = int.Parse(Console.ReadLine());
                }
                string prompt = Listing.GetPrompt();
                Listing myListing = new Listing(welcome, time, thankyou, prompt);
                myListing.DisplayWelcome();
                Console.WriteLine("Your Prompt is: " + prompt);
                Console.Write("Get ready, your activity starts in: ");
                myListing.ShowTimer(10);
                Console.WriteLine();
                DateTime end = DateTime.Now.AddSeconds(time);
                int count = 0;
                while (DateTime.Now < end)
                {
                    Console.Write("> ");
                    string input = Console.ReadLine();
                    count++;
                }

                Console.WriteLine("You entered " + count + " responses.");
                myListing.DisplayThankYou();
                listingCount += 1;
                start = Console.ReadLine();
            }
            else if (decision == "3")
            {
                string welcome = "Welcome to the breathing activity, in this activity you will be intructed to breath in and then breath out for 5 seconds a piece.";
                string thankyou = "Well done!!!\n\nThankyou for doing the bretahing activity, you may press enter to do another activity or enter any key to end.";
                Console.WriteLine("How much time would you like to spend on the activity? Please enter an integer that is a multiple of 10(10, 20, 30, etc)");
                int time = int.Parse(Console.ReadLine());
                while (time % 10 != 0)
                {
                    Console.Write("That is not a multiple of ten, please try again: ");
                    time = int.Parse(Console.ReadLine());
                }
                int breathCycleCount = Breathing.GetBreathCycleCount(time);
                Breathing myBreathing = new Breathing(welcome, time, thankyou, breathCycleCount);
                myBreathing.DisplayWelcome();
                Console.Write("Get ready, your activity starts in: ");
                myBreathing.ShowTimer(10);
                for (int i = 0; i < breathCycleCount; i++)
                {
                    myBreathing.BreathCycleDisplay();
                }
                myBreathing.DisplayThankYou();
                breathingCount += 1;
                start = Console.ReadLine();
            }
        }
    }
}