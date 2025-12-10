public class Order
{
    private Customer _customer;
    public List<Product> _products = new List<Product>();
    public Order()
    {

    }
    public void GetOrderTotalCost()
    {
        // Total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
    }
    public string GetPackingLabel()
    {
        return "";
    }
}