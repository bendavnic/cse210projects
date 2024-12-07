public class Address
{
    string street;
    string city;
    string state;
    string country;
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }
    public Address(string street, string city, string country)
    {
        this.country = country;
        this.street = street;
        this.city = city;
    }
    public bool IsUSA()
    {
        if (country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string FullAddress()
    {
        if (!string.IsNullOrEmpty(state))
        {
            return street + "\n" + city + ", " + state + "\n" + country;
        }
        else
        {
            return street + "\n" + city + "\n" + country;
        }
    }
}