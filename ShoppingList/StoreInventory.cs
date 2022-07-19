
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
                {"Bananas", 1.00m},
                {"Onions", 3.75m},
                {"Donuts", 0.75m},
                {"Grapes", 1.99m}
            };

        public static void PrintStoreInventory()
        {
            Console.Clear();
            int itemNumber = 1;
            Console.WriteLine("Welcome to Chirpus Market!");
            Console.WriteLine("    Item      Price");
            Console.WriteLine("=====================");
            foreach(var kvp in storeInventory)
            {
                Console.WriteLine($"{itemNumber++, -2}: {kvp.Key,-10} {kvp.Value}");
            }
        }
    }
}