using System.Reflection.Emit;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double OrderTotalCost()
    {
        double OrderTotalCost = 0;
        foreach(Product product in _products)
        {
            OrderTotalCost += product.totalCost();
        }

        if (_customer.IsInTheUSA())
        {
            OrderTotalCost += 5;
        }
        else 
        {
            OrderTotalCost += 35;
        }

        return OrderTotalCost;
    }

    public string PackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();

        foreach(Product product in _products)
        {
            string name = product.getProduct();
            string productId = product.getProductID();

            packingLabel.AppendLine($"Packing Label: Product: {name}, ID: {productId}");
        } 

        return packingLabel.ToString();
    } 

    public string ShippingLabel()
    {
        string customerName = _customer.getName();
        String address = _customer.getAddress().Display();

        string shippingLabel = $"Shipping Label : Name: {customerName}, Address: {address}";
        return  shippingLabel;
    }
}