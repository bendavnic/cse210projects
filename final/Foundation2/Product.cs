public class Product
{
    string name;
    int id;
    double price;
    int quantity;
    public Product(Order order, string name, int id, double price, int quantity = 1)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
        order.AddProduct(this);
    }
    public double totalCost
    {
        get { return price * quantity; }
    }
    public string ItemLine()
    {
        return quantity + "x " + id + ": " + name;
    }
}