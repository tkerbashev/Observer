namespace Observer
{
    /// <summary>
    /// Trader who wishes to sell stock
    /// </summary>
    /// <param name="name">The name of the trader</param>
    /// <param name="maximumPrice">Selling if the price raises above this level</param>
    public class TraderSeller( string name, decimal maximumPrice ) : IPriceChangeListener
    {
        private readonly string _name = name;

        public decimal MaximumPrice { get; set; } = maximumPrice;
        public void ReceivePriceChangeNotification( PriceChange priceChange )
        {
            if (priceChange != null && priceChange.Price > MaximumPrice)
            {
                Console.WriteLine( $"{_name}: The price is above the threshold. I am selling!" );
            }
            else
            {
                Console.WriteLine( $"{_name}: Staying put" );
            }
        }
    }
}
