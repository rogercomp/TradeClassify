using System;
using TradeClassification.Enums;
using TradeClassification.Interfaces;

namespace TradeClassification.Model
{
    public class TradeDefaulted : ITrade
    {
        public double Value { get; }
        public string ClientSector { get; }
        public DateTime NextPaymentDate { get; }
        public Classification TradeClassify { get; set; }
        public DateTime RefDate { get; }

        public TradeDefaulted()
        {

        }

        public TradeDefaulted(double value, string clientSector, DateTime nextPaymentDate, DateTime refDate)
        {
            this.Value = value;
            this.ClientSector = clientSector;
            this.NextPaymentDate = nextPaymentDate;
            this.RefDate = refDate;
            DoClassification();
        }

        public TradeDefaulted(ITrade trade)
        {
            this.Value = trade.Value;
            this.ClientSector = trade.ClientSector;
            this.NextPaymentDate = trade.NextPaymentDate;
            this.RefDate = trade.RefDate;
            DoClassification();
        }


        public override string ToString()
        {
            return this.TradeClassify.ToString();
        }

        public void DoClassification()
        {
            var diffDataPayment = (this.RefDate - this.NextPaymentDate).TotalDays;
        
            if (diffDataPayment > 30) 
            {
                this.TradeClassify = Classification.DEFAULTED;
            }
            else
            {
                this.TradeClassify = Classification.NOCATEGORY;
            }
        }
    }
}
