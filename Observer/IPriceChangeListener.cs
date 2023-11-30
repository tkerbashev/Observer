namespace Observer
{
    public interface IPriceChangeListener
    {
        void ReceivePriceChangeNotification( PriceChange priceChange );
    }
}
