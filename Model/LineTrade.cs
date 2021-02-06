using System;
using TradeClassification.Enums;

namespace TradeClassification.Model
{
    public class LineTrade
    {
        public double Value { get; }
        public string ClientSector { get; }
        public DateTime NextPaymentDate { get; }
        public DateTime ReferenceDate { get; }
        public Classification TradeClassify { get; set; }
      
         public LineTrade(double value, string clientSector, DateTime nextPaymentDate, DateTime referenceDate)
         {
             this.Value = value;
             this.ClientSector = clientSector;
             this.NextPaymentDate = nextPaymentDate;
             this.ReferenceDate = referenceDate;
         }       
    }
}
