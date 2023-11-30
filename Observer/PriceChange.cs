namespace Observer
{
    public class PriceChange( decimal price )
    {
        public decimal Price { get; private set; } = price;
    }
}
