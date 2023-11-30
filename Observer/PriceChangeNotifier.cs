namespace Observer
{
    public abstract class PriceChangeNotifier
    {
        private readonly List<IPriceChangeListener> _listeners = [];

        public void AddObserver(IPriceChangeListener listener)
        {
            _listeners.Add(listener);
        }

        public void RemoveObserver(IPriceChangeListener listener) 
        {
            _listeners.Remove(listener);
        }

        public void Notify(PriceChange priceChange)
        {
            foreach (var listener in _listeners)
            {
                listener.ReceivePriceChangeNotification(priceChange);
            }
        }
    }
}
