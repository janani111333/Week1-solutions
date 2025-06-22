using System;

class Program
{
    static void Main(string[] args)
    {
        // STEP A: Create an array of Products
        Product[] products = new Product[]
        {
            new Product(1, "Phone", "Electronics"),
            new Product(2, "Laptop", "Electronics"),
            new Product(3, "Shirt", "Apparel"),
            new Product(4, "Book", "Education"),
            new Product(5, "Headphones", "Electronics")
        };
        
        // Get product name from the user
        Console.Write("Enter the product name to search: ");
        string? targetName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(targetName))
        {
            Console.WriteLine("Product name cannot be empty.");
            return;
        }

        // === LINEAR SEARCH Demo ===
        Console.WriteLine("\n=== LINEAR SEARCH Demo ===");
        Product? linearResult = LinearSearch(products, targetName);
        Console.WriteLine(linearResult != null ? $"Found: {linearResult}" : "Product Not Found");

        // === BINARY SEARCH Demo ===
        // First sort by product name
        Array.Sort(products, (a, b) => string.Compare(a.ProductName, b.ProductName, StringComparison.OrdinalIgnoreCase));
        
        Console.WriteLine("\n=== BINARY SEARCH Demo ===");
        Product? binaryResult = BinarySearch(products, targetName);
        Console.WriteLine(binaryResult != null ? $"Found: {binaryResult}" : "Product Not Found");
    }

    // Linear Search by name
    static Product? LinearSearch(Product[] products, string targetName)
    {
        foreach (var p in products)
        {
            if (p.ProductName.Equals(targetName, StringComparison.OrdinalIgnoreCase))
                return p;
        }
        return null;
    }

    // Binary Search by name
    static Product? BinarySearch(Product[] products, string targetName)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            int cmp = string.Compare(products[mid].ProductName, targetName, StringComparison.OrdinalIgnoreCase);

            if (cmp == 0) return products[mid];
            if (cmp < 0) left = mid + 1;
            else right = mid - 1;
        }
        return null;
    }
}

