using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> current_entries = new List<Entry>();
    public void Menu()
    {
        string run = "yes";
        while (run == "yes")
        {
            int action_number;
            Console.WriteLine("Please pick from the these using the number coorelated\n" +
                                "1) Write new prompt\n " +
                                "2) Display all current entries\n" +
                                "3) Save all journal inputs\n" +
                                "4) Load journal\n" +
                                "5) Quit\n" +
                                "Please input 1, 2, 3, 4, or 5\n"
                                );
            action_number = int.Parse(Console.ReadLine());
            if (action_number == 1)
            {
                Entry NewEntry = new Entry();
                NewEntry.SetNewEntry();
                current_entries.Add(NewEntry);
                Console.WriteLine("Your entry has been added to the list of current entries");

            }
            else if (action_number == 2)
            {
                if (current_entries.Count > 0)
                {
                    foreach (Entry x in current_entries)
                    {
                        Console.WriteLine(x.PromptLine);
                        Console.WriteLine(x.Response);
                        Console.WriteLine(x.Date);
                        Console.WriteLine("\n\n");
                    }
                }
                else
                {
                    Console.WriteLine("There are no current entries");
                }
            }
            else if (action_number == 3)
            {
                
                if (current_entries.Count > 0)
                {
                    string filename_save;
                    Console.WriteLine("Please enter the file you would like to append to: ");
                    filename_save = Console.ReadLine();
                    foreach (Entry x in current_entries)
                    {
                        File.AppendAllText(filename_save,
                        $"{x.PromptLine}\n" +
                        $"{x.Response}\n" +
                        $"{x.Date}\n\n");
                    }
                    Console.WriteLine($"Your entries were saved to {filename_save}");
                }
                else
                {
                    Console.WriteLine("There are no current entries");
                }
            }
            else if (action_number == 4)
            {
                Console.WriteLine("Please enter the file you would like to load and display: ");
                string filename_load = Console.ReadLine();
                if (File.Exists(filename_load))
                {
                    string filename_entries = File.ReadAllText(filename_load);
                    Console.WriteLine(filename_entries);
                }
                else
                {
                    Console.WriteLine($"{filename_load} does not exist");
                }
            }
            else if (action_number == 5)
            {
                run = "no";
            }
            else
            {
                Console.WriteLine("Invalid input: Please enter an integer between 1 and 5.");
            }
        }
    }    
}