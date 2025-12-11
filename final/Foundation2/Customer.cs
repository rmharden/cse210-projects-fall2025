public class Customer
{
    private Address _address;
    private string _name;

    public Customer(string name, Address address)
    {
        _address = address;
        _name = name;
    }
    public string GetCustomerName()
    {
        return _name;
    }
    // do I need this if it's done in the contructor?
    public void SetCustomerName(string name)
    {
        _name = name;
    }
    public bool IsCustomerUSA()
    {
        // Not sure here:
        // if (_address.IsAddressUSA() == true)
        // {
        //     return 5;
        // }
        // else
        // {
        //     return 35;
        // }
        return _address.IsAddressUSA();
    }
}