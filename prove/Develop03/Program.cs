using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the reference of the scripture you want to memorize: ");
        string reference = Console.ReadLine();
        Console.Write("Please enter the text of the scripture you want to memorize: ");
        string text = Console.ReadLine();
        Console.Clear();
        string answer = "";
        while (answer != "quit")
        {
            Console.WriteLine($"{reference}: {text}.");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            answer = Console.ReadLine();
            Console.Clear();
        }
    }
}