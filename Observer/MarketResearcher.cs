namespace Observer
{
    /// <summary>
    /// A market researches who only observes the stock price behaviour
    /// </summary>
    /// <param name="name">The name of the researcher</param>
    public class MarketResearcher( string name ) : IPriceChangeListener
    {
        private readonly string _name = name;

        public void ReceivePriceChangeNotification( PriceChange priceChange )
        {
            Console.WriteLine($"{_name}: Recording that the price changed to {priceChange.Price:C}.");
        }
    }
}
