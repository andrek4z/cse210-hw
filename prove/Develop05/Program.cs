using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        int points = 0;
        List<string> goalslist = new List<string>();
        List<string> goalsfile = new List<string>();
        List<string> goalsname = new List<string>();

        while (choice != "6")
        {
            Console.Clear();
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();
            Console.WriteLine("Menu options: ");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goaltype = Console.ReadLine();

                if (goaltype == "1")
                {
                    int amount = 0;
                    bool completed = false;
                    Console.Write("What is the name of the goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    amount = int.Parse(Console.ReadLine());
                    goalslist.Add($"[ ] {name} - ({description})");
                    goalsname.Add(name);
                    SimpleGoal sTypeGoal = new SimpleGoal(name, description, amount, completed);
                    string information = sTypeGoal.GetTypeGoal();
                    goalsfile.Add(information);
                }
                
                else if (goaltype == "2")
                {
                    int amount = 0;
                    Console.Write("What is the name of the goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    amount = int.Parse(Console.ReadLine());
                    goalslist.Add($"[ ] {name} - ({description})");
                    goalsname.Add(name);
                    EternalGoal eTypeGoal = new EternalGoal(name, description, amount);
                    string information = eTypeGoal.GetTypeGoal();
                    goalsfile.Add(information);
                }

                else if (goaltype == "3")
                {   
                    int times = 0;
                    int bonus = 0;
                    int amount = 0;
                    int timescompleted = 0;
                    Console.Write("What is the name of the goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    amount = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    times = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    bonus = int.Parse(Console.ReadLine());
                    goalslist.Add($"[ ] {name} - ({description}) ---> Currently completed: {timescompleted}/{times}");
                    goalsname.Add(name);
                    ChecklistGoal cTypeGoal = new ChecklistGoal(name, description, amount, bonus, times, timescompleted);
                    string information = cTypeGoal.GetTypeGoal();
                    goalsfile.Add(information);
                }
            }
            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("The goals are: ");
                for (int i= 1; i <= goalslist.Count; i++)
                {
                    Console.WriteLine("{0}.{1} ", i, goalslist[i - 1]);
                }

                Console.WriteLine();
                Console.WriteLine("Press enter to continue: ");
                string answer = Console.ReadLine();
            }
            else if (choice == "3")
            {
                Console.WriteLine();
                SaveToFile(goalsfile);
            }
            else if (choice == "4")
            {
                Console.WriteLine();
                List<string> newgoalslist = ReadFromFile();
                foreach(string n in newgoalslist)
                {
                    string[] parts = n.Split(":");
                    goalslist.Add(n);
                }
            }
            else if (choice == "5")
            {
                Console.Clear();
                Console.WriteLine("The Goals are: ");

                for (int i= 1; i <= goalsname.Count; i++)
                {
                    Console.WriteLine("{0}.{1} ", i, goalsname[i - 1]);
                }

                Console.Write("Which goal did you accomplish? ");
            }
        }
    }

    public static void SaveToFile(List<string> goalsfile)
    {
        Console.Write("What is the filename? ");
        string name = Console.ReadLine();

        string filename = $"{name}";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string m in goalsfile)
            {
                outputFile.WriteLine(m);
            }
        }
    }

     public static List<string> ReadFromFile()
    {
        Console.Write("What is the name of the file? ");
        string namefile = Console.ReadLine();

        List<string> listofgoals = new List<string>();
        string filename = $"{namefile}";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        return listofgoals;
    }
}