using Observer;

Console.WriteLine( "Observer Behavioural Design Pattern example" );

TraderBuyer buyer = new("Buyer", 11.3m);
TraderSeller seller = new("Seller", 18.65m);
MarketResearcher researcher = new("Researcher");

StockMarketService stockMarketService = new();
stockMarketService.AddObserver(buyer);
stockMarketService.AddObserver(seller);
stockMarketService.AddObserver( researcher);

stockMarketService.ReactToPriceChange( 19.45m );
stockMarketService.ReactToPriceChange( 16.77m );

Console.WriteLine("\nRemoving the market researcher");
stockMarketService.RemoveObserver(researcher);

stockMarketService.ReactToPriceChange( 8.75m );
stockMarketService.ReactToPriceChange( 13.14m );



