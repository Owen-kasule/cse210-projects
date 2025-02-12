public class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public string Name => _name;
    public int ProductID => _productID;

    public Product(string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    // Calculate the total cost of the product
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}
