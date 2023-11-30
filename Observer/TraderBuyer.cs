namespace Observer
{
    /// <summary>
    /// Trader who wishes to buy stock
    /// </summary>
    /// <param name="name">The name of the trader</param>
    /// <param name="minimumPrice">Buying if the price falls below this level</param>
    public class TraderBuyer( string name, decimal minimumPrice ) : IPriceChangeListener
    {
        private readonly string _name = name;

        public decimal MinimumPrice { get; set; } = minimumPrice;
        public void ReceivePriceChangeNotification( PriceChange priceChange )
        {
            if ( priceChange != null && priceChange.Price < MinimumPrice ) 
            {
                Console.WriteLine($"{_name}: The price is under the threshold. I am buying!");
            }
            else
            {
                Console.WriteLine( $"{_name}: Staying put" );
            }
        }
    }
}
