public class Products
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Products(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetID()
    {
        return _id;
    }

    public string GetName()
    {
        return _name;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public string GetNameAndID()
    {
        return $"{_name} - {_id}";
    }
    public double GetPriceOfProducts()
    {
        return _price*_quantity;
    }
}