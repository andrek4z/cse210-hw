using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Reference r = new Reference();
        Console.Write("Please enter the reference of the scripture you want to memorize: ");
        string reference = Console.ReadLine();
        r.SetReference(reference);
        Console.Write("Please enter the text of the scripture you want to memorize: ");
        string text = Console.ReadLine();
        string[] textList = text.Split(" ");
        Console.Clear();
        string answer = "";
        while (answer != "quit")
        {
            Console.Clear();
            if (answer == "")
            {
                Console.WriteLine($"{r.GetReference()}: {text}.");
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
                answer = Console.ReadLine();
                Random rand = new Random();
                int randomIndex = rand.Next(textList.Length);
                textList[randomIndex] = "____";
                text = string.Join(" ",textList);
            }
        }
    }
}