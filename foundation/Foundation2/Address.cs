using System.Transactions;

public class Address
{
    private string _address;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country)
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool IsInTheUSA()
    {
        if(_country.ToLower() == "usa" || _country.ToLower() == "united states")
        {
            return true;
        }

        else
        {
            return false;
        }

    }

    public string Display()
    {
        string address = @$"{_address}, {_country}, {_city}, {_state}";

        return address;
    }
}