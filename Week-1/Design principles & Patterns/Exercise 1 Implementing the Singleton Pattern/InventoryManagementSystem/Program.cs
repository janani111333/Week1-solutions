using System;

namespace InventoryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new();

            while (true)
            {
                Console.WriteLine("\n=== Inventory Menu ===");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. Delete Product");
                Console.WriteLine("4. Display Products");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice)) continue;

                switch (choice)
                {
                    case 1:
                        AddProduct(inventory);
                        break;
                    case 2:
                        UpdateProduct(inventory);
                        break;
                    case 3:
                        DeleteProduct(inventory);
                        break;
                    case 4:
                        inventory.DisplayInventory();
                        break;
                    case 5:
                        Console.WriteLine("Exiting... Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }

        static void AddProduct(Inventory inventory)
        {
            Console.Write("\nEnter Product ID: ");
            int id = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter Quantity: ");
            int qty = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter Price: ");
            decimal price = decimal.Parse(Console.ReadLine() ?? "0");

            inventory.AddProduct(new Product(id, name, qty, price));
        }

        static void UpdateProduct(Inventory inventory)
        {
            Console.Write("\nEnter Product ID to update: ");
            int id = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter new Product Name: ");
            string name = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter new Quantity: ");
            int qty = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter new Price: ");
            decimal price = decimal.Parse(Console.ReadLine() ?? "0");

            inventory.UpdateProduct(id, name, qty, price);
        }

        static void DeleteProduct(Inventory inventory)
        {
            Console.Write("\nEnter Product ID to delete: ");
            int id = int.Parse(Console.ReadLine() ?? "0");
            inventory.DeleteProduct(id);
        }
    }
}
