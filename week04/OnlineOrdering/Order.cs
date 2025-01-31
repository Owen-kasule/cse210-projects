using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }
        total += _customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string GeneratePackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.Name}, ID: {product.ProductID}\n";
        }
        return label;
    }

    public string GenerateShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetFullName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
