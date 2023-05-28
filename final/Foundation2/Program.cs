using System;

class Program
{
    public static void Main(string[] args)
    {
        Products product11 = new Products("Cheese","10NK500", 10.50, 6);
        Products product12 = new Products("Bottle of milk","24NK543", 8.60, 12);

        Customer customer1 = new Customer("Martin Garrix", new Address("350 Main Street", "Seattle", "Washington", "USA"));

        List<Products> products1 = new List<Products>();
        products1.Add(product11);
        products1.Add(product12);
        Order order1 = new Order(products1, customer1);

        Console.Clear();
        Console.WriteLine("First Customer: -----------------------------------------------------------------");
        Console.WriteLine();
        string shippingLabel1 = order1.GetShippingLabel();
        Console.WriteLine("Shipping label: " + shippingLabel1);

        string packingLabel1 = order1.GetPackingLabel();
        Console.WriteLine("Packing label:\n" + packingLabel1);

        double totalPrice1 = order1.GetTotalPrice();
        Console.WriteLine("Total price: $" + totalPrice1);

        Products product21 = new Products("Soda","10NK987", 5.50, 8);
        Products product22 = new Products("Cereal","14NK443", 8.60, 20);

        Customer customer2 = new Customer("Kate Denson", new Address("Mz L lt 27 Alto Mochica", "Trujillo", "La Libertad", "Peru"));

        List<Products> products2 = new List<Products>();
        products2.Add(product21);
        products2.Add(product22);
        Order order2 = new Order(products2, customer2);

        Console.WriteLine();
        Console.WriteLine("Second Customer: -----------------------------------------------------------------");
        Console.WriteLine();
        string shippingLabel2 = order2.GetShippingLabel();
        Console.WriteLine("Shipping label: " + shippingLabel2);

        string packingLabel2 = order2.GetPackingLabel();
        Console.WriteLine("Packing label:\n" + packingLabel2);

        double totalPrice2 = order2.GetTotalPrice();
        Console.WriteLine("Total price: $" + totalPrice2);
    }
}