using System;

class Program
{
    static void Main()
    {
        Address address = new Address("660 North", "Nibly", "UT", "USA");
        Customer customer = new Customer("Andrew", address);
        Product product1 = new Product("Laptop", 101, 1000, 1);
        Product product2 = new Product("Mouse", 102, 25, 2);

        Address address2 = new Address("123 Main St", "Midde", "Of", "Canada");
        Customer customer2 = new Customer("Johny", address2);
        Product product3 = new Product("Headphones", 103, 150, 1);
        Product product4 = new Product("Keyboard", 104, 25, 1);

        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Packing Label:\n" + order.GetPackingLabel());
        Console.WriteLine("\nShipping Label:\n" + order.GetShippingLabel());
        Console.WriteLine("\nTotal Cost: $" + order.CalculateTotal());

        Console.WriteLine("\nPacking Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("\nShipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("\nTotal Cost: $" + order2.CalculateTotal());
    }
}
