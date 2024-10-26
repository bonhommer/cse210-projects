using System.Runtime.CompilerServices;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string getName()
    {
        return _name;
    }

    public Address getAddress()
    { 
        return _address;
    }
    public bool IsInTheUSA()
    {
       return _address.IsInTheUSA();
    }
}