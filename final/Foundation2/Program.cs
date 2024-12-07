using System;

class Program
{
    static void Main(string[] args)
    {
        //Order 1
        Address adds1 = new Address("8014 Honeyfield Lane", "Spring", "Texas", "USA");
        Customer cust1 = new Customer("Ben Nicholas", adds1);
        Order order1 = new Order(cust1);
        Product product1 = new Product(order1, "1200-watt Microwave", 6547721, 179.99);
        Product product2 = new Product(order1, "24-pack AA Batteries", 8665179, 12.47, 3);
        order1.Printout();

        //Order 2
        Address adds2 = new Address("156 Caville Street", "Madrid", "Spain");
        Customer cust2 = new Customer("Sebastian Castillo", adds2);
        Order order2 = new Order(cust2);
        Product product3 = new Product(order2, "Victorinox 12-inch Carving Knife", 1246001, 89.99);
        Product product4 = new Product(order2, "Butterfinger King Size, 18-pack", 0054879, 15.75, 4);
        Console.WriteLine("\n");
        order2.Printout();
    }
}