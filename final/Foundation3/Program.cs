using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Lectures l1 = new Lectures("IA and future of technology","Lecture where we are going to talk about the future",DateTime.Now,TimeSpan.FromHours(2),new Address("Juan Carlos Villareal 050","Trujillo","La Libertad","Peru"),"John Connors",500);
        Console.WriteLine(l1.GetStandarDetails());
        Console.WriteLine(l1.GetFullDetails());
        Console.WriteLine(l1.GetShortDescription());

        Console.WriteLine();
        Receptions r1 = new Receptions("Mary and John's Wedding","A special day for us",DateTime.Now,TimeSpan.FromHours(1),new Address("Urb. Primavera 1550","Trujillo","La Libertad","Peru"),"marylovesFlowers@gmail.com");
        Console.WriteLine(r1.GetStandarDetails());
        Console.WriteLine(r1.GetFullDetails());
        Console.WriteLine(r1.GetShortDescription());

        Console.WriteLine();
        OutdoorGathering o1 = new OutdoorGathering("Family Picnic","A special picnic with all the family",DateTime.Now,TimeSpan.FromHours(1),new Address("Urb Moche 400","Trujillo","La Libertad","Peru"),"Sunny");
        Console.WriteLine(o1.GetStandarDetails());
        Console.WriteLine(o1.GetFullDetails());
        Console.WriteLine(o1.GetShortDescription());
    }
}