using static ShoppingList.StoreInventory;
using static ShoppingList.ShoppingCart;
using static ShoppingList.AddItem;

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
                if(AddItemToCart()) continue;
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