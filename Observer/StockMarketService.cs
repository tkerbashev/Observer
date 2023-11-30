namespace Observer
{
    public class StockMarketService : PriceChangeNotifier
    {
        public void ReactToPriceChange( decimal newPrice )
        {
            Console.WriteLine( $"\nThe stock price just changed to {newPrice:C} and we are notifying all the listeners..." );
            Notify( new PriceChange( newPrice ) );
        }
    }
}
