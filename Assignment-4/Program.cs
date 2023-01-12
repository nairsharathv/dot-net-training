/*
    Assignment - 4
    Shopping Cart
    Design a shopping cart system that allows user to get the total price of an order.

    ShoppingCartEntry {
        Quantity, Price
    }

    ShoppingCart
    {
        List<ShoppingCartEntry> entries;
    }

    Order
    {
        double _tax;
        GetTotalPrice() {
            // implementation
        }
    }
*/





ShoppingCart shoppingCart = new ShoppingCart();
shoppingCart.AddToCart();

Order order = new Order();
order.GetTotalPrice();