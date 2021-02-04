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
        public Classification TradeClassify { get; set; }
        public DateTime RefDate { get; }

        public TradeMediumRisk()
        {

        }

        public TradeMediumRisk(double value, string clientSector, DateTime nextPaymentDate, DateTime refDate)
        {
            this.Value = value;
            this.ClientSector = clientSector;
            this.NextPaymentDate = nextPaymentDate;
            this.RefDate = refDate;
            DoClassification();
        }

        public TradeMediumRisk(ITrade trade)
        {
            this.Value = trade.Value;
            this.ClientSector = trade.ClientSector;
            this.NextPaymentDate = trade.NextPaymentDate;
            this.RefDate = trade.RefDate;
            DoClassification();
        }

        public void DoClassification()
        {
            if (this.Value > 1000000 && this.ClientSector.ToUpper() == "PUBLIC")
                this.TradeClassify = Classification.MEDIUMRISK;
            else
            {
                this.TradeClassify = Classification.NOCATEGORY;
            }            
        }

        public override string ToString()
        {
            return this.TradeClassify.ToString();
        }
    }
}
