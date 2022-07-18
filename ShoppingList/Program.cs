using static ShoppingList.StoreInventory;
using static ShoppingList.ShoppingCart;

namespace ShoppingList
{
    internal class Program
    {
        static void Main()
        {
            bool addMoreItems = true;
            string[] no = { "n" , "no"};
            do
            {
                PrintStoreInventory();

                string add = Console.ReadLine();

                if(storeInventory.ContainsKey(add))
                {
                    foreach(var kvp in storeInventory)
                    {
                        if(add == kvp.Key)
                        {
                            shoppingCart.Add(kvp.Key);                       
                            break;
                        }
                    }
                }
                else if(int.TryParse(add, out int index) && index -1  < storeInventory.Count)
                {
                    shoppingCart.Add(storeInventory.ElementAt(index - 1).Key);
                }
                else
                {
                    Console.WriteLine("Sorry we don't have that item.");
                    Console.Write("Press any key to continue.");
                    Console.ReadKey();
                    continue;
                }
                printShoppingCart();
                Console.Write("Would you like to add more items Y/N?");
                if(no.Contains(Console.ReadLine().ToLower().Trim()))
                {
                    addMoreItems = false;
                }
            } while(addMoreItems);

            decimal total = printShoppingCart();
            Console.WriteLine($"Your total for today comes to {total}");
        }
    }
}