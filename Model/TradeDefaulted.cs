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
        public DateTime ReferenceDate { get; }

        public TradeDefaulted()
        {

        }

        public TradeDefaulted(LineTrade _lineTrade)
        {
            this.Value = _lineTrade.Value;
            this.ClientSector = _lineTrade.ClientSector;
            this.NextPaymentDate = _lineTrade.NextPaymentDate;
            this.ReferenceDate = _lineTrade.ReferenceDate;
        }

        public string DoClassification(LineTrade _lineTrade)
        {
            var diffDataPayment = (_lineTrade.ReferenceDate - _lineTrade.NextPaymentDate).TotalDays;
            if (diffDataPayment > 30)
            {
                this.TradeClassify = Classification.DEFAULTED;                
            }
            else
            {
                this.TradeClassify = Classification.NOCATEGORY; 
            }
            return this.TradeClassify.ToString();
        }      
    }
}
