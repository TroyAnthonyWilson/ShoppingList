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
            string[] no = { "no", "exit", "checkout", "pay", };
  
            do
            {
                PrintStoreInventory();
                if(AddItemToCart()) continue;
                total = PrintShoppingCart();

                Write("Press any key to add more items or Pay to checkout: ");
                string addToCartAgain = ReadLine().ToLower().Trim();
                if(no.Where(n => n.StartsWith(addToCartAgain)).Any())
                {
                    addMore = false;
                }

            } while(addMore);

            WriteLine($"Your total for today comes to {total}");
        }
    }
}