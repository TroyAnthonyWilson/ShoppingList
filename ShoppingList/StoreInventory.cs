using static System.Console;

namespace ShoppingList
{
    internal class StoreInventory
    {
        public static Dictionary<string, decimal> storeInventory = new()
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
                {"Grapes", 1.99m},
                {"Oranges", 4.99m}
            };

        public static void PrintStoreInventory()
        {
            Clear();
            int itemNumber = 1;
            WriteLine("Welcome to Chirpus Market!");
            WriteLine("    Item      Price");
            WriteLine("=====================");
            storeInventory.ToList().ForEach(i => WriteLine($"{itemNumber++,-2}: {i.Key,-12}{i.Value}"));
        }
    }
}