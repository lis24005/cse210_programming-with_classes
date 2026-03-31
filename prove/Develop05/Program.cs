using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Goal> goals = new List<Goal>();
        string choice = "";
        while (choice != "6")
        {
            int pointsCount = 0;
            foreach (Goal goals2 in goals)
            {
                pointsCount += goals2.CalculatePoints();
            }

            Console.WriteLine($"You have {pointsCount} point(s).");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal.");
            Console.WriteLine("  2. List Goals.");
            Console.WriteLine("  3. Save Goals.");
            Console.WriteLine("  4. Load Goals.");
            Console.WriteLine("  5. Record Event.");
            Console.WriteLine("  6. quit.");
            Console.Write("Select an choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                int goalSelection;
                Console.WriteLine("What type of goal would you like create?");
                Console.WriteLine(" 1. Simple");
                Console.WriteLine(" 2. Eternal");
                Console.WriteLine(" 3. Checklist");
                Console.Write("   ->");
                goalSelection = int.Parse(Console.ReadLine());

                if (goalSelection == 1)
                {
                    Console.Write("What is the name of your goal: ");
                    string name = Console.ReadLine();
                    Console.Write("What the description of your goal: ");
                    string description = Console.ReadLine();
                    Console.Write("How many points is your goal worth: ");
                    int points = int.Parse(Console.ReadLine());
                    Simple mySimple = new Simple(name, description, points);
                    goals.Add(mySimple);
                }
                else if (goalSelection == 2)
                {
                    Console.Write("What is the name of your goal: ");
                    string name = Console.ReadLine();
                    Console.Write("What the description of your goal: ");
                    string description = Console.ReadLine();
                    Console.Write("How many points is your goal worth: ");
                    int points = int.Parse(Console.ReadLine());
                    Eternal myEternal = new Eternal(name, description, points);
                    goals.Add(myEternal);
                }
                else if (goalSelection == 3)
                {
                    Console.Write("What is the name of your goal: ");
                    string name = Console.ReadLine();
                    Console.Write("What the description of your goal: ");
                    string description = Console.ReadLine();
                    Console.Write("How many points is your goal worth: ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("How many bonus points is it worth: ");
                    int bonus = int.Parse(Console.ReadLine());
                    Console.Write("How many times must it be completed to get the bonus points: ");
                    int times = int.Parse(Console.ReadLine());
                    Checklist myChecklist = new Checklist(name, description, points, times, bonus);
                    goals.Add(myChecklist);
                }
                else
                {
                    Console.WriteLine("Invalid input, please input a number between 1 and 3");
                }
            }
            else if (choice == "2")
            {
                if (goals.Count > 0)
                {
                    foreach (Goal goal in goals)
                    {
                        goal.DisplayGoal();
                    }
                }
                else
                {
                    Console.WriteLine("You have no current goals");
                }
            }
            else if (choice == "3")
            {
                Console.Write("What is the name of the file you would like to save to? (don't forget to add .txt): ");
                string file = Console.ReadLine();
                FileManager myFile = new FileManager();
                myFile.SaveGoals(file, goals, pointsCount);
            }
            else if (choice == "4")
            {
                Console.Write("What is the name of the file you would like to load to? (don't forget to add .txt): ");
                string file = Console.ReadLine();
                Console.WriteLine("What would you to do?");
                Console.WriteLine("  1. Merge with current goals");
                Console.WriteLine("  2. Replace current goals with new load");
                Console.Write("   ->");
                int mergeChoice = int.Parse(Console.ReadLine());

                FileManager myfile = new FileManager();

                if (mergeChoice == 1)
                {
                    List<Goal> loadGoals = myfile.LoadGoals(file, out _);
                    goals.AddRange(loadGoals);
                }
                else if (mergeChoice == 2)
                {
                    goals = myfile.LoadGoals(file, out _);
                }
            }
            else if (choice == "5")
            {
                Console.WriteLine("The goals are:");
                int eventNumber = 0;

                foreach (Goal goal in goals)
                {
                    eventNumber += 1;
                    Console.WriteLine($"{eventNumber}. {goal.GetName()}");
                }

                Console.Write("Which goal did you accomplish? ");
                int goalCompleted = int.Parse(Console.ReadLine());

                eventNumber = 0;

                foreach (Goal goal in goals)
                {
                    eventNumber += 1;

                    if (eventNumber == goalCompleted)
                    {
                        goal.SetComplete();
                        Console.WriteLine($"Congrats, you have earned {goal.CalculatePoints()} points!");

                        pointsCount = 0;
                        foreach (Goal goals2 in goals)
                        {
                            pointsCount += goals2.CalculatePoints();
                        }

                        Console.WriteLine($"You now have {pointsCount} points");
                    }
                }
            }
            else if (choice == "6")
            {
                choice = "6";
            }
            else
            {
                Console.WriteLine("Invalid input, please input a number between 1 and 6");
            }
        }
    }
}