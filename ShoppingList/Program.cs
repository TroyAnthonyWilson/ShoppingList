using static ShoppingList.StoreInventory;
using static ShoppingList.ShoppingCart;

namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool addMoreItems = true;
            string[] yes = { "y" , "yes", ""};
            do
            {
                printStoreInventory();
                //string mostExpensive = storeInventory.FirstOrDefault(x => x.Value == storeInventory.Values.Max()).Key;
                //string leastExpensive = storeInventory.FirstOrDefault(x => x.Value == storeInventory.Values.Min()).Key;
                //Console.WriteLine($"{mostExpensive} {storeInventory[mostExpensive]}");
                //Console.WriteLine($"{leastExpensive} {storeInventory[leastExpensive]}");
                string add = Console.ReadLine();

                if(storeInventory.ContainsKey(add))
                {
                    shoppingCart.Add(add);
                }
                else if(int.TryParse(add, out int index) && index -1  < storeInventory.Count)
                {
                    shoppingCart.Add(storeInventory.ElementAt(index - 1).Key);
                }
                else
                {
                    Console.WriteLine("Sorry we don't have that item.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    continue;
                }
                printShoppingCart();
                Console.WriteLine("Would you like to add more items Y/N?");
                if(!yes.Contains(Console.ReadLine().ToLower().Trim()))
                {
                    addMoreItems = false;
                }
            } while(addMoreItems);

            decimal total = printShoppingCart();
            Console.WriteLine($"Your total for today comes to {total}");

        }
    }
}