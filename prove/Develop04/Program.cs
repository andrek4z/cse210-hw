using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        int seconds = 0;
        while(choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Breathing Activity.");
                Console.WriteLine();
                Console.WriteLine("This activity will help you to relax by walking your trough breathing in and out slowly.");
                Console.WriteLine("Clear your mind and focus your breathing.");
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for your session? ");
                seconds = int.Parse(Console.ReadLine());

                Breathing a1 = new Breathing(seconds,"Breathing Activity");
                Console.Clear();
                Console.WriteLine("Get Ready.....");
                Console.WriteLine();
                Animation();
                DateTime startime = DateTime.Now;
                DateTime endtime = startime.AddSeconds(seconds);

                while (DateTime.Now < endtime)
                {
                    Console.Write("Breathe in...");
                    for (int i=3; i>0; i--)
                    {
                        Console.Write(i);
                        Thread.Sleep(1000);
                        Console.Write("\b \b");
                    }
                    Console.WriteLine();
                    Console.Write("Now breathe out...");
                    for (int i=6; i>0; i--)
                    {
                        Console.Write(i);
                        Thread.Sleep(1000);
                        Console.Write("\b \b");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }

                Console.WriteLine("Well Done!!");
                Animation();
                Console.WriteLine();
                Console.WriteLine(a1.GetBreathingActivity());
                Animation();
            }

            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Reflecting Activity.");
                Console.WriteLine();
                Console.WriteLine("This activity will help you reflect on times in your life when you shown strength and resilience.");
                Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for your session? ");
                seconds = int.Parse(Console.ReadLine());
                Reflecting a2 = new Reflecting(seconds, "Reflecting Activity");
                Console.Clear();
                Console.WriteLine("Get Ready.....");
                Animation();
                SelectPrompt();
                Console.WriteLine("when you have something in mind, press enter to continue");
                Console.ReadLine();
                Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
                Console.Write("You may begin...");
                    for (int i=5; i>0; i--)
                    {
                        Console.Write(i);
                        Thread.Sleep(1000);
                        Console.Write("\b \b");
                    }

                Console.Clear();
                SelectQuestion();
                Console.WriteLine();
                SelectQuestion();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Well Done!!");
                Animation();
                Console.WriteLine();
                Console.WriteLine(a2.GetReflectingActivity());
                Animation();
            }

            else if (choice == "3")
            {
                Console.Clear();
                Console.WriteLine("Welcome to the listing Activity.");
                Console.WriteLine();
                Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many");
                Console.WriteLine("things as you can in certain area.");
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for your session? ");
                seconds = int.Parse(Console.ReadLine());
                Listing a3 = new Listing(seconds,"Listing Activity");
                DateTime startime = DateTime.Now;
                DateTime endtime = startime.AddSeconds(seconds);
                List<string> goodthings = new List<string>();
                Console.Clear();
                Console.WriteLine("Get Ready.....");
                Animation();
                Console.WriteLine("List as many responses you can to the folliwing prompt: ");
                SelectQuestionII();
                Console.Write("You may begin...");
                    for (int i=5; i>0; i--)
                    {
                        Console.Write(i);
                        Thread.Sleep(1000);
                        Console.Write("\b \b");
                    }

                Console.WriteLine();

                while(DateTime.Now < endtime)
                { 
                Console.Write("> ");
                string bless = Console.ReadLine();
                goodthings.Add(bless);
                }
                // I add this function to save all the things I listed in the activity, all the elements in the list are stored in a
                // file.
                SaveToFile(goodthings);
                Console.WriteLine();
                Console.WriteLine("Well Done!!");
                Animation();
                Console.WriteLine();
                Console.WriteLine(a3.GetListingActivity());
                Animation();
            }
        }
        
    }

    public static void Animation()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public static void SelectPrompt()
    {
        string filename = "Prompt.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        Random rand = new Random();
        int randomIndex = rand.Next(lines.Length);
        Console.WriteLine();
        Console.WriteLine(lines[randomIndex]);
        Console.WriteLine();
    }

    public static void SelectQuestion()
    {
        string filename = "Question.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        Random rand = new Random();
        int randomIndex = rand.Next(lines.Length);
        Console.Write(lines[randomIndex]);
        Animation();
    }
    
    public static void SelectQuestionII()
    {
        string filename = "QuestionII.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        Random rand = new Random();
        int randomIndex = rand.Next(lines.Length);
        Console.WriteLine();
        Console.WriteLine(lines[randomIndex]);
        Console.WriteLine();
    }
    
    // This is the function that save all the elements in the list into a txt File.
    public static void SaveToFile(List<string> goodthings)
    {
        Console.Write("What is the filename? ");
        string name = Console.ReadLine();

        string filename = $"{name}";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string m in goodthings)
            {
                outputFile.WriteLine(m);
            }
        }
    }
}