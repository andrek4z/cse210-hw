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
                string filename = "Questions.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);
                Console.Write("< ");
                string diary = Console.ReadLine();
            }
            else if (number == 2)
            {
                
            }
            else if (number == 3)
            {

            }
            else if (number == 4)
            {

            }
        }
    }

    public static void SaveToFile(List<Journal> message)
    {
        string filename = "Journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Journal m in message)
            {
                outputFile.WriteLine($"{m._content}");
            }
        }
    }

    public static List<Journal> ReadFromFile()
    {
        List<Journal> message = new List<Journal>();
        string filename = "Journal.txt";

        return message;
    }
}