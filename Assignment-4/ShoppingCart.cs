class ShoppingCart
{
    List<CartEntry> entries;

    public void AddToCart() 
    {
        bool isShopping = true;
        entries = new List<CartEntry>();
        while (isShopping)
        {
            Console.Write("Enter item name: ");
            string itemName = Console.ReadLine();
            Console.Write("Enter item quantity: ");
            int orderQuantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter item price: ");
            int itemPrice = Convert.ToInt32(Console.ReadLine());

            CartEntry cartEntry = new CartEntry(ItemName: itemName, Quantity: orderQuantity, Price: itemPrice);
            entries.Add(cartEntry);
            Console.WriteLine("Item added to cart successfully");
            Console.Write("Press Q to quit or any other letter to continue shopping: ");
            char quit = Convert.ToChar(Console.ReadLine());
            if (quit.Equals('Q'))
            {
                isShopping = false;
            }
        }
    }

    public void GetOrder()
    {
        Order order = new Order(entries);
        order.GetTotalPrice();
    }

}