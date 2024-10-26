public class Product
{
    private string _product;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string product, string productId, double price, int quantity)
    {
        _product = product;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string getProduct()
    {
        return _product;
    }

    public string getProductID()
    { 
        return _productId;
    }
    public double totalCost()
    {
        return _price * _quantity;
    }
}