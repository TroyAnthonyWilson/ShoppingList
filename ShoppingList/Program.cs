using static ShoppingList.StoreInventory;
using static ShoppingList.ShoppingCart;

namespace ShoppingList
{
    internal class Program
    {
        static void Main()
        {
            bool addMore = true;
            string[] no = { "n", "no", "exit", "e", "checkout" };
            do
            {
                PrintStoreInventory();

                string add = Console.ReadLine().ToLower().Trim();

                if(storeInventory.Keys.Where(key => key.ToLower().StartsWith(add)).Any())
                {
                    string[] position = storeInventory.Keys.Where(key => key.ToLower().StartsWith(add)).ToArray();
                    if(position.Length == 1)
                    {
                        foreach(var kvp in storeInventory)
                        {
                            if(position[0] == kvp.Key)
                            {
                                shoppingCart.Add(new ShoppingCart(kvp.Key, kvp.Value));
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("I couldn't find what you wanted");
                        Console.Write("Press any key to continue.");
                        Console.ReadKey();
                        continue;
                    }
                }
                else if(int.TryParse(add, out int index) && index - 1 < storeInventory.Count)
                {
                    shoppingCart.Add(new ShoppingCart(storeInventory.ElementAt(index - 1).Key,
                        storeInventory.ElementAt(index - 1).Value));
                }
                else
                {
                    Console.WriteLine("Sorry we don't have that item.");
                    Console.Write("Press any key to continue.");
                    Console.ReadKey();
                    continue;
                }

                PrintShoppingCart();

                Console.Write("Press any key to add more items or NO to checkout: ");

                if(no.Contains(Console.ReadLine().ToLower().Trim()))
                {
                    addMore = false;
                }

            } while(addMore);

            Console.WriteLine($"Your total for today comes to {PrintShoppingCart()}");
        }
    }
}