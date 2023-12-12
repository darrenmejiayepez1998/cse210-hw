using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal total = 0;

        foreach (var product in products)
        {
            total += product.CalculateProductTotal();
        }

        // Shipping cost based on customers location
        total += customer.IsInUSA() ? 5 : 35;

        return total;
    }

    public string GetPackingLabel()
    {
        // this can be customize to other formats
        return $"Packing Label: {customer.Name}\n{string.Join("\n", products)}";
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.Name}\n{customer.Address}";
    }
}