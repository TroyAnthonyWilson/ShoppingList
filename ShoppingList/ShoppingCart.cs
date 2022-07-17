using static ShoppingList.StoreInventory;

namespace ShoppingList
{
    internal class ShoppingCart
    {
        public static List<string> shoppingCart = new List<string>();


        public static decimal printShoppingCart()
        {
            decimal total = 0;
            decimal mostExpensive = 0;
            decimal leastExpensive = 1000;
            Console.Clear();
            Console.WriteLine("Shopping cart\n");

            foreach(var item in shoppingCart)
            {
                if(storeInventory[item] > mostExpensive)
                {
                    mostExpensive = storeInventory[item];
                }
                if(storeInventory[item] < leastExpensive)
                {
                    leastExpensive = storeInventory[item];
                }
                
            }

            foreach(var item in shoppingCart)
            {
                Console.Write($"{item,-12} {storeInventory[item]}");
                if(storeInventory[item] == mostExpensive)
                {
                    Console.WriteLine("   Most expensive item");
                }
                else if(storeInventory[item] == leastExpensive)
                {
                    Console.WriteLine("   Least expensive item");
                }
                total += storeInventory[item];
            }
            Console.WriteLine($"\nCart total : {total}");
            return total;
        }
    }
}