using static System.Console;

namespace ShoppingList
{
    internal class ShoppingCart
    {
        public static List<ShoppingCart> shoppingCart = new();
        
        private readonly string item;
        private readonly decimal price;

        public ShoppingCart(string item, decimal price)
        {
            this.item = item;
            this.price = price;
        }

        public string GetItem { get { return item; } }
        public decimal GetPrice { get { return price; } }

        public static decimal PrintShoppingCart(string desc)
        {
            decimal total = 0;
            int itemNumber = 1;
            Clear();
            WriteLine(desc);
            WriteLine("==================\n");

            shoppingCart.OrderBy(x => x.GetPrice).ToList()
                .ForEach(i => WriteLine($"{itemNumber++,-2}: {i.GetItem,-12}{i.GetPrice}"));

            total = shoppingCart.Sum(item => item.GetPrice);
            WriteLine("\n=======================");
            WriteLine($"{desc} total : {total}\n");
            return total;
        }
    }
}