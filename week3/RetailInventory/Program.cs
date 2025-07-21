using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        // ✅ Retrieve all products
        var products = await context.Products.ToListAsync();
        Console.WriteLine("\nAll Products:");
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
        }

        // ✅ Find product by ID
        var productById = await context.Products.FindAsync(1);
        Console.WriteLine($"\nProduct with ID=1: {productById?.Name}");

        // ✅ First product where price > ₹50000
        var expensiveProduct = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
        Console.WriteLine($"\nExpensive Product: {expensiveProduct?.Name}");
    }
}
