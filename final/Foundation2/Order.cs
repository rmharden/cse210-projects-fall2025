public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(List<Product> products)
    {
        products = _products = new List<Product>();
    }
    public void AddProductToOrder()
    {

    }
    public double GetOrderTotalCost()
    {
        // Total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
        // string country;
        // if (country == "USA")
        // {
        //     return 5;
        // }
        // else
        // {
        //     return 35;
        // }
        return 0;
    }
    public string GetPackingLabel()
    {
        return "";
    }
    public string GetShippingLabel()
    {
        return "";
    }
}