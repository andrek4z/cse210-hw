using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        List<Journal> message = new List<Journal>();

        while (number != 5)
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            number = int.Parse(Console.ReadLine());
            
            if (number == 1)
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                string filename = "Questions.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);
                Random rand = new Random();
                int randomIndex = rand.Next(lines.Length);
                Console.WriteLine(lines[randomIndex]);
                Console.Write("< ");
                string diary = Console.ReadLine();

                Journal m = new Journal();
                m._date = dateText;
                m._question = lines[randomIndex];
                m._content = diary;
                
                message.Add(m);
            }
            else if (number == 2)
            {
                foreach(Journal m in message)
                {
                    Console.WriteLine($"Date: {m._date} ~ Prompt: {m._question}");
                    Console.WriteLine($"{m._content}");
                }
            }
            else if (number == 3)
            {
                List<Journal> newMessage = ReadFromFile();
                foreach (Journal m in newMessage)
                {
                    Console.WriteLine($"Date: {m._date} ~ Prompt: {m._question}");
                    Console.WriteLine($"{m._content}");
                }
            }
            else if (number == 4)
            {
                SaveToFile(message);
            }
        }

        Console.WriteLine("Thanks for typing in your journal one more day");
    }

    public static void SaveToFile(List<Journal> message)
    {
        Console.Write("What is the filename? ");
        string name = Console.ReadLine();

        string filename = $"{name}";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Journal m in message)
            {
                outputFile.WriteLine($"Date: {m._date} ~ Prompt: {m._question}");
                outputFile.WriteLine($"{m._content}");
            }
        }
    }

    public static List<Journal> ReadFromFile()
    {
        Console.Write("What is the name of the file? ");
        string namefile = Console.ReadLine();

        List<Journal> message = new List<Journal>();
        string filename = $"{namefile}";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        return message;
    }
}