public class Customer
{
    private Address _address;
    private string _name;

    public Customer(string name, Address address)
    {
        _address = address;
        _name = name;
    }

    public double IsCustomerUSA()
    {
        if (_address.IsAddressUSA() == true)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
}