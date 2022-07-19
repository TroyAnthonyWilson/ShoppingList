using static ShoppingList.StoreInventory;

namespace ShoppingList
{
    internal class ShoppingCart
    {
        public static List<ShoppingCart> shoppingCart = new List<ShoppingCart>();
        private string item;
        private decimal price;

        public ShoppingCart(string item, decimal price)
        {
            this.item = item;
            this.price = price; 
        }

        public string GetItem { get { return item; } }
        public decimal GetPrice { get { return price; } }

        public static decimal PrintShoppingCart()
        {
            decimal total = 0;
            int itemNumber = 1;
            Console.Clear();
            Console.WriteLine("Shopping cart\n");

            shoppingCart.OrderBy(x => x.GetPrice)
                .ToList()
                .ForEach(i => Console.WriteLine($"{itemNumber++,-2}: {i.GetItem,-12}{i.GetPrice}"));

            total = shoppingCart.Sum(item => item.GetPrice);
            Console.WriteLine($"\nCart total : {total}\n");
            return total;
        }
    }
}