using static ShoppingList.StoreInventory;

namespace ShoppingList
{
    internal class ShoppingCart
    {
        public static List<string> shoppingCart = new List<string>();


        public static decimal printShoppingCart()
        {
            int itemNumber = 1;
            decimal total = 0;
            decimal mostExpensive = 0;
            decimal leastExpensive = 1000;
            Console.Clear();
            Console.WriteLine("Shopping cart\n");

            List<string> shoppingCartList = shoppingCart.ToList();

            foreach(var item in shoppingCartList)
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

            do
            {
                decimal nextToPrint = 1000;
                foreach(var item in shoppingCartList)
                {
                    if(storeInventory[item] < nextToPrint)
                    {
                        nextToPrint = storeInventory[item];
                    }
                }
                foreach(var item in shoppingCart)
                {
                    bool nextLine = false;
                    foreach(var kvp in storeInventory)
                    {
                        if(storeInventory[item] == nextToPrint && storeInventory[item] == kvp.Value)
                        {
                            Console.Write($"{itemNumber, -2}: {kvp.Key,-12} {kvp.Value}");
                            total += kvp.Value;
                            shoppingCartList.Remove(item);
                            itemNumber++;
                            nextLine = true;
                            break;
                        }
                    }

                    if(nextLine)
                    {
                        if(storeInventory[item] == mostExpensive)
                        {
                            Console.Write("   Most expensive item");
                        }
                        else if(storeInventory[item] == leastExpensive)
                        {
                            Console.Write("   Least expensive item");
                        }
                        Console.WriteLine();
                    }
                } 
            } while(shoppingCartList.Count > 0);
            Console.WriteLine($"\nCart total : {total}");
            return total;
        }
    }
}