using static ShoppingList.StoreInventory;
using static ShoppingList.ShoppingCart;

namespace ShoppingList
{
    internal class AddItem
    {
        public static bool AddItemToCart()
        {
            Console.Write("\nPlease select an item to add to your cart: ");
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
                            return false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Sorry I couldn't find what you wanted");
                    Console.Write("Press any key to continue.");
                    Console.ReadKey();
                    return true;
                }
            }
            else if(int.TryParse(add, out int index) && index - 1 < storeInventory.Count)
            {
                shoppingCart.Add(new ShoppingCart(storeInventory.ElementAt(index - 1).Key,
                    storeInventory.ElementAt(index - 1).Value));
                return false;
            }
            else
            {
                Console.WriteLine("Sorry we don't have that item.");
                Console.Write("Press any key to continue.");
                Console.ReadKey();
                return true;
            }
            return false;
        }
    }
}
