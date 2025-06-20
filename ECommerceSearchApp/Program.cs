using System;
using System.Collections.Generic;
using System.Linq;

// Product class
public class Product
{
    public string Name;
    public string Category;
    public string Brand;
    public double Price;

    public Product(string name, string category, string brand, double price)
    {
        Name = name;
        Category = category;
        Brand = brand;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - {Category} - {Brand} - ₹{Price}";
    }
}

// Filter Strategy Interface
public interface ISearchStrategy
{
    List<Product> Search(List<Product> products, string criteria);
}

// Search by Category
public class CategorySearch : ISearchStrategy
{
    public List<Product> Search(List<Product> products, string category)
    {
        return products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}

// Search by Brand
public class BrandSearch : ISearchStrategy
{
    public List<Product> Search(List<Product> products, string brand)
    {
        return products.Where(p => p.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}

// Context class
public class SearchContext
{
    private ISearchStrategy strategy;

    public void SetSearchStrategy(ISearchStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void ExecuteSearch(List<Product> products, string criteria)
    {
        var results = strategy.Search(products, criteria);
        Console.WriteLine("Search Results:");
        foreach (var product in results)
        {
            Console.WriteLine(product);
        }
    }
}

// Main Program
public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product("Laptop", "Electronics", "Dell", 55000),
            new Product("Smartphone", "Electronics", "Samsung", 20000),
            new Product("Shirt", "Clothing", "Puma", 1500),
            new Product("Shoes", "Footwear", "Nike", 3000),
            new Product("Smartwatch", "Electronics", "Noise", 3500),
        };

        SearchContext context = new SearchContext();

        Console.WriteLine("Search by: 1. Category  2. Brand");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string choice = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        if (choice == "1")
        {
            Console.Write("Enter Category: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string category = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            context.SetSearchStrategy(new CategorySearch());
            context.ExecuteSearch(products, category);
        }
        else if (choice == "2")
        {
            Console.Write("Enter Brand: ");
            string brand = Console.ReadLine();
            context.SetSearchStrategy(new BrandSearch());
            context.ExecuteSearch(products, brand);
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }
}
