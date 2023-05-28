using System;
using System.Collections.Generic;
public class Order
{
    private List<Products> _products;
    private Customer _customer;

    public Order(List<Products> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    public List<Products> GetProducts()
    {
        return _products;
    }
    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Products product in _products)
        {
            totalPrice += product.GetPriceOfProducts();
        }
        if (_customer.LivesInUsa())
        {
            return totalPrice + 5;
        }
        else
        {
            return totalPrice + 35;
        }
    }

    public string GetPackingLabel()
    {
        var packingLabel = "";
        foreach (var product in _products)
        {
            packingLabel += $"*{product.GetNameAndID()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()} / {_customer.GetAddress().GetAllAddress()}";
    }
}