using System;
using System.Collections.Generic;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        private Dictionary<int, Product> products = new();

        public void AddProduct(Product product)
        {
            products[product.ProductId] = product;
            Console.WriteLine($"Added: {product}");
        }

        public void UpdateProduct(int productId, string newName, int newQuantity, decimal newPrice)
        {
            if (products.ContainsKey(productId))
            {
                var p = products[productId];
                p.ProductName = newName;
                p.Quantity = newQuantity;
                p.Price = newPrice;
                Console.WriteLine($"Updated: {p}");
            }
            else
            {
                Console.WriteLine($"Product {productId} not found!");
            }
        }

        public void DeleteProduct(int productId)
        {
            if (products.Remove(productId))
                Console.WriteLine($"Removed product {productId}");
            else
                Console.WriteLine($"Product {productId} not found!");
        }

        public void DisplayInventory()
        {
            Console.WriteLine("\nCurrent Inventory:");
            foreach (var product in products.Values)
            {
                Console.WriteLine(product);
            }
        }
    }
}
