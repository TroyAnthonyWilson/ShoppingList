using static ShoppingList.StoreInventory;
using static ShoppingList.ShoppingCart;
using static System.Console;

namespace ShoppingList
{
    internal class AddItem
    {
        public static bool AddItemToCart()
        {
            Write("\nPlease select an item to add to your cart: ");
            string add = ReadLine().ToLower().Trim();

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
                    WriteLine("Sorry I couldn't find what you are looking for.\nPress any key to continue.");
                    ReadKey();
                    return true;
                }
            }
            else if(int.TryParse(add, out int index) && --index < storeInventory.Count)
            {
                shoppingCart.Add(new ShoppingCart(storeInventory.ElementAt(index).Key,
                    storeInventory.ElementAt(index).Value));
                return false;
            }
            else
            {
                WriteLine("Sorry we don't have that item.\nPress any key to continue.");
                ReadKey();
                return true;
            }
            return false;
        }
    }
}