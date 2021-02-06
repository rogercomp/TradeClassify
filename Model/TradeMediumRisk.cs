using System;
using TradeClassification.Enums;
using TradeClassification.Interfaces;

namespace TradeClassification.Model
{
    public class TradeMediumRisk : ITrade
    {
        public double Value { get; }
        public string ClientSector { get; }
        public DateTime NextPaymentDate { get; }
        public Classification TradeClassify { get; private set; }
        public DateTime ReferenceDate { get; }

        public TradeMediumRisk()
        {

        }       

        public TradeMediumRisk(LineTradeDTO _lineTrade)
        {
            this.Value = _lineTrade.Value;
            this.ClientSector = _lineTrade.ClientSector;
            this.NextPaymentDate = _lineTrade.NextPaymentDate;
            this.ReferenceDate = _lineTrade.ReferenceDate;            
        }
             
        public string DoClassification()
        {
            if (this.Value > 1000000 && this.ClientSector.ToUpper() == "PUBLIC")
                this.TradeClassify = Classification.MEDIUMRISK;
            else
            {
                this.TradeClassify = Classification.NOCATEGORIZED;
            }
            return this.TradeClassify.ToString();
        }
    }
}
