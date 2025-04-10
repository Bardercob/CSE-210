using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Bleh", "Blehbleh", "blugh", "USA");
        Customer customer1 = new Customer("Billy", address1);
        Order order1 = new Order(customer1);
        Product order1product1 = new Product("Candle", 209342, 1.00, 7);
        order1.AddProduct(order1product1);
        Product order1product2 = new Product("Candy", 208403, 0.25, 20);
        order1.AddProduct(order1product2);
        Product order1product3 = new Product("Washing-machine", 21002, 200.00, 1);
        order1.AddProduct(order1product3);
        Address address2 = new Address("200 Cherry Ln", "blah blah", "Blah", "Blahkland");
        Customer customer2 = new Customer("Billy", address2);
        Order order2 = new Order(customer2);
        Product order2product1 = new Product("Plastic chair", 184039, 2.99, 18);
        order2.AddProduct(order2product1);
        Product order2product2 = new Product("Apple", 204932, 0.25, 8);
        order2.AddProduct(order2product2);
        Product order2product3 = new Product("Napkin(100 count)", 190028, 4.87, 3);
        order2.AddProduct(order2product3);

        Console.WriteLine("Packing Label:");
        order1.PackingLabel();
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        order1.ShippingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.FindTotalCost()}");
        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        order2.PackingLabel();
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        order2.ShippingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.FindTotalCost()}");
        
    }
}