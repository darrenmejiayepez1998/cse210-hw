using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Addressess
        Address usaAddress = new Address("151 North St", "Seattle", "WA", "USA");
        Address internationalAddress = new Address("456 High St", "Seville","Betis", "Spain");

        // Customer creation
        Customer usaCustomer = new Customer("Hypatia Johnson", usaAddress);
        Customer internationalCustomer = new Customer("Andres Guardado", internationalAddress);

        // Order creation
        Order order1 = new Order(usaCustomer);
        Order order2 = new Order(internationalCustomer);

        // Add products to orders
        order1.AddProduct(new Product("Mario RPG", 1, 59.99m, 1));
        order1.AddProduct(new Product("Steven Universe complete series", 1, 32.99m, 1));

        order2.AddProduct(new Product("Soccer ball", 3, 5.99m, 3));
        order2.AddProduct(new Product("Nescafe coffee", 4, 15.79m, 2));
        order2.AddProduct(new Product("Rice from japan", 2, 9.99m, 2));

        // Displays packing label, shipping label and total price for each order
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Order Details:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotalPrice():F2}\n"); 
    }
}