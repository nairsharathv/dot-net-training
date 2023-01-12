class Order
{
    double _tax;
    double _totalCheckoutPrice = 0;
    List<CartEntry> entries;

    public void GetTotalPrice()
    {
        // iterate item from list
        // add item price
        // add tax
        _tax = 0.05;
        entries = new List<CartEntry>();
        Console.WriteLine(entries.Count());
        foreach (CartEntry entry in entries)
        {   
            Console.Write(entry);
        }
        
    }
}