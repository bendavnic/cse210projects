public class Order
{
    Customer customer;
    List<Product> products;
    double shippingCost;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
        if (customer.IsUSA)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
    }
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public string ListProducts()
    {
        string list = "";
        foreach (var product in products)
        {
            list += product.ItemLine() + "\n";
        }
        return list;
    }
    public string PackingLabel()
    {
        return customer.Name + "\n" + ListProducts();
    }
    public string ShippingLabel()
    {
        return customer.Name + "\n" + customer.Address;
    }
    public double Total()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.totalCost;
        }
        totalCost += shippingCost;

        return totalCost;
    }
    public double Subtotal()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.totalCost;
        }
        return totalCost;
    }
    public void Printout()
    {
        Console.WriteLine("Packing Label:\n" + PackingLabel());
        Console.WriteLine("Shipping Label:\n" + ShippingLabel());
        Console.WriteLine($"\nSubtotal:\t ${Subtotal():F2}");
        Console.WriteLine($"Shipping:\t + ${shippingCost:F2}");
        Console.WriteLine("------------------");
        Console.WriteLine($"Total:\t \t ${Total():F2}");
    }
}