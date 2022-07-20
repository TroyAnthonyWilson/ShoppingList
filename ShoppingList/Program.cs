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
            string[] no = { "no", "exit", "checkout", "pay", };
  
            do
            {
                PrintStoreInventory();
                if(AddItemToCart()) continue;
                PrintShoppingCart("Shopping cart");

                Write("Press any key to add more items or Pay to checkout: ");
                string addToCartAgain = ReadLine().ToLower().Trim();
                if(no.Where(n => n.StartsWith(addToCartAgain)).Any() && addToCartAgain != "")
                {
                    addMore = false;
                }

            } while(addMore);

            Clear();
            decimal total = PrintShoppingCart("Receipt");
            WriteLine($"Your total today comes to {total}");
        }
    }
}