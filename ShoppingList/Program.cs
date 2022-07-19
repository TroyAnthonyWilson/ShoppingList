using static ShoppingList.StoreInventory;
using static ShoppingList.ShoppingCart;
using static ShoppingList.AddItem;
using static System.Console;

namespace ShoppingList
{
    internal class Program
    {
        static void Main()
        {
            bool addMore = true;
            decimal total = 0;
            string[] no = { "n", "no", "exit", "e", "checkout" };
  
            do
            {
                PrintStoreInventory();
                if(AddItemToCart()) continue;
                total = PrintShoppingCart();

                Write("Press any key to add more items or NO to checkout: ");

                if(no.Contains(ReadLine().ToLower().Trim()))
                {
                    addMore = false;
                }

            } while(addMore);

            WriteLine($"Your total for today comes to {total}");
        }
    }
}