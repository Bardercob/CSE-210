class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string SetAddress()
    {
        return _address.AddressStringFormat();
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool InUSA()
    {
        return _address.InUSA();
    }
}