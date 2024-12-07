public class Customer
{
    string name;
    Address address;
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }
    public bool IsUSA
    {
        get { return address.IsUSA(); }
    }
    public string Name
    {
        get { return name; }
    }
    public string Address
    {
        get { return address.FullAddress(); }
    }
}
