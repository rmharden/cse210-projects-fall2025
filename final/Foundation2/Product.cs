public class Product
{
    private string _productName;
    private string _productId;
    private double _productPrice;
    private int _productQty;

    public Product(string productName, string productId, double productPrice, int productQty)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQty = productQty;
    }
    public string GetProductName()
    {
        return _productName;
    }
    public string GetProductID()
    {
        return _productId;
    }
    
    public double CalculateCost()
    {
        return _productPrice * _productQty;
    }
}