using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Oak St", "Othertown", "NY", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Laptop", "123456", 1000, 2);
        Product product2 = new Product("Mouse", "789012", 20, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine("Total Price: " + order1.CalculateTotalCost());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine("Total Price: " + order2.CalculateTotalCost());
    }
}
