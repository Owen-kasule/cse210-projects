using System;

public class Program
{
    public static void Main()
    {
        // Create customers and their addresses
        Address address1 = new Address("123 Main St", "Kampala", "Central", "Uganda");
        Customer customer1 = new Customer("Muwanguzi Joseph", address1);

        Address address2 = new Address("456 Nkrumah Ave", "Nairobi", "Nairobi County", "Kenya");
        Customer customer2 = new Customer("Achieng Beatrice", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("MacBook Pro", 101, 1200, 1));
        order1.AddProduct(new Product("Wireless Mouse", 102, 25, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Samsung Galaxy S22", 201, 850, 1));
        order2.AddProduct(new Product("Bluetooth Speaker", 202, 45, 1));

        // Display Order Details
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"💰 Total Price: ${order1.CalculateTotalPrice()}");

        Console.WriteLine("\n-------------------------------------\n");

        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"💰 Total Price: ${order2.CalculateTotalPrice()}");
    }
}
