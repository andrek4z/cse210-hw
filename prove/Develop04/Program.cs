using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

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
                Console.Write("How long, in seconds, would you like for your session?");
                string second = Console.ReadLine();
            }

            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Reflecting Activity.");
                Console.WriteLine();
                Console.WriteLine("This activity will help you reflect on times in your life when you shown strength and resilience.");
                Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for your session?");
                string second = Console.ReadLine();
            }

            else if (choice == "3")
            {
                Console.Clear();
                Console.WriteLine("Welcome to the listing Activity.");
                Console.WriteLine();
                Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many");
                Console.WriteLine("things as you can in certain area.");
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for your session?");
                string second = Console.ReadLine();
            }
        }
        
    }
}