using TradeClassification.Interfaces;

namespace TradeClassification.Model
{
    public class TradeFactory : ITradeFactory
    {
        public ITrade GetObjectTrade(LineTrade trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector.ToUpper() == "PUBLIC")
            {
                return new TradeMediumRisk();
            }
            else if (trade.Value > 1000000 && trade.ClientSector.ToUpper() == "PRIVATE")
            {
                return new TradeHighRisk();
            }
            return new TradeDefaulted();
        }
    }
}
