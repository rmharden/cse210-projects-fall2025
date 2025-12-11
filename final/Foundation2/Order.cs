public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(List<Product> products, Customer customer)
    {
        _products = products = new List<Product>();
        _customer = customer;
    }
    public void AddProductToOrder(Product product)
    {
        _products.Add(product);
    }
    public double GetOrderTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.CalculateCost();
        }
        if (_customer.IsCustomerUSA() == true)
        {
            return totalCost += 5;
        }
        else
        {
            return totalCost += 35;
        }
    }
    public string GetPackingLabel()
    {
        Product p1 = new Product(Lost);
        return $"Packing Label\n================ {}";
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label\n================ {_customer.GetCustomerName()}\n{_customer.GetCustomerAddress}";
    }
}


/*

I left off here. I need to go through the description and see what I am missing.

*/