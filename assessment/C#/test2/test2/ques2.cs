﻿using System;

class Product : IComparable<Product>
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }

    public int CompareTo(Product other)
    {
        return this.Price.CompareTo(other.Price);
    }

    public override string ToString()
    {
        return $"Product ID: {ProductId}, Product Name: {ProductName}, Price: {Price:C}";
    }
}

class ques2
{
    static void Main(string[] args)
    {
        Product[] products = new Product[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Enter details for Product {i + 1}:");
            Console.Write("Product ID: ");
            int productId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Product Name: ");
            string productName = Console.ReadLine();
            Console.Write("Price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            products[i] = new Product { ProductId = productId, ProductName = productName, Price = price };
        }
        Array.Sort(products);


        Console.WriteLine("Sorted Products acc to Price:");
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
}