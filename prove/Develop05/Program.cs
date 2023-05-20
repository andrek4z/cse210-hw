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
                string type = Console.ReadLine();
                Console.Write("What is the name of the goal? ");
                string goal = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string amount = Console.ReadLine();
                goalslist.Add($"[] {goal} - ({description})");
            }
            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("The goals are: ");
                foreach (string g in goalslist)
                {
                    Console.WriteLine(g);
                }

                Console.WriteLine();
                Console.WriteLine("Press enter to continue: ");
                string answer = Console.ReadLine();
            }
            else if (choice == "3")
            {
                Console.WriteLine();
                SaveToFile(goalslist);
            }
            else if (choice == "4")
            {
                //Console.WriteLine();
                //ReadFromFile();
            }
            else if (choice == "5")
            {
                
            }
        }
    }

    public static void SaveToFile(List<string> goalslist)
    {
        Console.Write("What is the filename? ");
        string name = Console.ReadLine();

        string filename = $"{name}";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string m in goalslist)
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