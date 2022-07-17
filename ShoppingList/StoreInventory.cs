using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    internal class StoreInventory
    {

        public static Dictionary<string, decimal> storeInventory = new Dictionary<string, decimal>()
            {
                {"Milk", 1.50m},
                {"Eggs", 1.25m},
                {"Sugar", 3.50m},
                {"Bread", 2.75m},
                {"Hot Dogs", 5.99m},
                {"Buns", 2.90m},
                {"Avocado", 2.65m},
                {"Bananas", 1.50m},
            };

        public static void printStoreInventory()
        {
            Console.Clear();
            int itemNumber = 1;
            Console.WriteLine("Store Inventory\n");
            foreach(var kvp in storeInventory)
            {
                Console.WriteLine($"{itemNumber}: {kvp.Key,-10} {kvp.Value}");
                itemNumber++;
            }
            Console.WriteLine("\nPlease select an item to add to your cart: ");
        }

    }
}
