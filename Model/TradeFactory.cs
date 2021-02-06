using TradeClassification.Interfaces;

namespace TradeClassification.Model
{
    public class TradeFactory : ITradeFactory
    {
        public ITrade GetObjectTrade(LineTradeDTO trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector.ToUpper() == "PUBLIC")
            {
                return new TradeMediumRisk(trade);
            }
            else if (trade.Value > 1000000 && trade.ClientSector.ToUpper() == "PRIVATE")
            {
                return new TradeHighRisk(trade);
            }
            return new TradeDefaulted(trade);
        }
    }
}
