using System;
// Make sure that all member variables are private and getters, setters, and constructors are created as needed.

// Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.
class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("Toothbrush", "W123", 2.99, 2);
        Product p2 = new Product("Potatoes", "P435", 6.99, 3);
        Product p3 = new Product("Beef Jerk", "b342", 7.99, 10);

        Address a1 = new Address(" 123 Main St", "Anytown", "CA", "USA");
        Customer c1 = new Customer("John Doe", a1);
        Address a2 = new Address(" 123 Main St", "New York", "NY", "USA");
        Customer c2 = new Customer("Jane Doe", a2);
        Address a3 = new Address("789 High St", "Toronto", "ON", "Canada");
        Customer c3 = new Customer("Boby Jone", a3);

        Order o1 = new Order();
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"Total cost: {o1.CalculateTotalCost():C}");

        Order o2 = new Order(c2);
        o2.AddProduct(p2);
        o2.AddProduct(p3);
        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"Total cost: {o2.CalculateTotalCost():C}");

    }
}