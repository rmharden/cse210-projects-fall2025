public class Address
{
    private string _street;
    private string _city;
    private string _stateProv;
    private string _country;

    public Address(string street, string city, string stateProv, string country)
    {
        _street = street;
        _city = city;
        _stateProv = stateProv;
        _country = country;
    }

    // I don't know if I need the getters and the setters.
    // public void SetCountry(string country)
    // {
    //     _country = country;
    // }
    
    public string GetCountry()
    {
        return _country;
    }

    public bool IsAddressUSA()
    {
        if (GetCountry().ToLower() != "usa")
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_stateProv}, {_country}";
    }
}