class Order
{
    double _tax;
    int _totalPrice = 0;
    double _totalCheckoutPrice = 0;
    List<CartEntry> entries;


    public Order(List<CartEntry> list)
    {
        this.entries = list;
    }
    public void GetTotalPrice()
    {
        
        Console.WriteLine(entries.Count());
        foreach (CartEntry entry in entries)
        {   
            _totalPrice += entry.Price;            
        }
        _tax = (_totalPrice * 0.05);
        _totalCheckoutPrice += _totalPrice + _tax;
        Console.WriteLine($"Your total amount to be paid is: Rs.{_totalCheckoutPrice}");

    }
}