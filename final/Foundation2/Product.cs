using System;
using System.Collections.Generic;

public class Product
{
    public string Name {get; private set;}
    public int ProductId {get; private set;}
    public decimal Price {get; private set;}
    public int Quantity {get; private set;}

    public Product(string name, int productId, decimal price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public decimal CalculateProductTotal()
    {
        return Price * Quantity;
    }
}