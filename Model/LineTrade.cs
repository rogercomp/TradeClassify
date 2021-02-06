using System;
using TradeClassification.Enums;
using TradeClassification.Interfaces;

namespace TradeClassification.Model
{
    public class LineTrade
    {
        public double Value { get; }
        public string ClientSector { get; }
        public DateTime NextPaymentDate { get; }
        public DateTime RefDate { get; }
        public Classification TradeClassify { get; set; }

        /* double Value { get; }
         string ClientSector { get; }
         DateTime NextPaymentDate { get; }
         DateTime RefDate { get; }
         Classification TradeClassify { get; set; }
        */
         public LineTrade(double value, string clientSector, DateTime nextPaymentDate, DateTime refDate)
         {
             this.Value = value;
             this.ClientSector = clientSector;
             this.NextPaymentDate = nextPaymentDate;
             this.RefDate = refDate;
         }

        /*
         public void DoClassification(LineTrade trade)
         {
             var diffDataPayment = (trade.RefDate - trade.NextPaymentDate).TotalDays;
             if (diffDataPayment > 30)
             {
                 this.TradeClassify = Classification.DEFAULTED;
             }
             else
             {
                 this.TradeClassify = Classification.NOCATEGORY;
             }
         }*/
    }
}
