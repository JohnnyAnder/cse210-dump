using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product(1, "Widget", 19.99m, 2);
        Product product2 = new Product(2, "Gadget", 29.99m, 1);
        Product product3 = new Product(3, "Doohickey", 9.99m, 5);
        Product product4 = new Product(4, "Sprocket", 14.99m, 3);

        List<Product> products1 = new List<Product> { product1, product2, product3 };
        List<Product> products2 = new List<Product> { product4, product3 };

        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order1 = new Order(products1, customer1);
        Order order2 = new Order(products2, customer2);


        customer1.ShippingLabel();
         Console.WriteLine();
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine();

        Thread.Sleep(2000);
         Console.WriteLine();
          Console.WriteLine();

        customer2.ShippingLabel();
         Console.WriteLine();
        Console.WriteLine(order2.PackingLabel());
    }
}