public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Check if the customer is based in the USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Get the full name of the customer
    public string GetFullName()
    {
        return _name;
    }

    // Get the address associated with the customer
    public Address GetAddress()
    {
        return _address;
    }
}

