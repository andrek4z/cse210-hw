using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        var running = new Running("31/02/2023", 40, 5.7);
        var cycling = new Bicycles("03/12/2023", 60, 10.8);
        var swimming = new Swimming("24/12/2022", 60, 15);

        var activities = new List<Activity>{running, cycling, swimming};

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}