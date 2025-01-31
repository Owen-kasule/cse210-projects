using System;

public class Program
{
    public static void Main()
    {
        // Create customers and addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 1000, 1));
        order1.AddProduct(new Product("Mouse", 102, 20, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", 201, 500, 1));
        order2.AddProduct(new Product("Headphones", 202, 50, 1));

        // Display order details
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");

        Console.WriteLine();

        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");
    }
}
