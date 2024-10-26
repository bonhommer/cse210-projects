using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("White sneaker", "1", 100, 1);
        Product product2 = new Product("iPhone 13 Pro max", "23", 900, 2);
        Product product3 = new Product("Keyboard", "003", 1000, 3);
        Product product4 = new Product("Monitor", "004", 300, 1);

        Address address1 = new Address("233 Myrtle Ave", "Irvington", "New Jersey", "USA"); 
        Address address2 = new Address("45 Maple Ave", "Toronto", "ON", "Canada");
       
        
        Customer customer1 = new Customer("Antoine Bonhommer", address1);
        Customer customer2 = new Customer("Jeff Bezos", address2);

        List<Product> orderProduct1 = new List<Product>();
        orderProduct1.Add(product1);
        orderProduct1.Add(product2);
        List<Product> orderProduct2 = new List<Product>();
        orderProduct2.Add(product3);
        orderProduct2.Add(product4);

        Order order1 = new Order(orderProduct1, customer1);
        Order order2 = new Order(orderProduct2, customer2);

        string packingLabel1 = order1.PackingLabel();
        string packingLabel2 = order2.PackingLabel();
        string shippingLabel1 = order1.ShippingLabel();
        string shippingLabel2 = order2.ShippingLabel();
        double totalCost1 = order1.OrderTotalCost();
        double totalCost2 = order2.OrderTotalCost();
      

        Console.WriteLine(@$"{packingLabel1}{shippingLabel1}
Total Cost: {totalCost1}");
        Console.WriteLine(@$"{packingLabel2}{shippingLabel2}
Total Cost: {totalCost2}");  
    }
}