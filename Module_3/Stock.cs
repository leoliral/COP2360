using System;

class Stock
{
    private decimal currentPrice;
    private decimal sharesOwned;

    public decimal CurrentPrice
    {
        get { return currentPrice; }
        set { currentPrice = value; }
    }

    public decimal SharesOwned
    {
        get { return sharesOwned; }
        set { sharesOwned = value; }
    }

    public decimal Worth
    {
        get { return currentPrice * sharesOwned; }
    }
}

class Program
{
    static void Main()
    {
        Stock myStock = new Stock();

        myStock.CurrentPrice = 50;
        myStock.SharesOwned = 100;

        Console.WriteLine("Stock Price: $" + myStock.CurrentPrice);
        Console.WriteLine("Shares Owned: " + myStock.SharesOwned);
        Console.WriteLine("Total Worth: $" + myStock.Worth);
    }
}
