using System;
using TradeClassification.Enums;
using TradeClassification.Model;

namespace TradeClassification.Interfaces
{
    public interface ITrade
    {
        public double Value { get; }
        public string ClientSector { get; }
        public DateTime NextPaymentDate { get; }
        public Classification TradeClassify { get; }
        public DateTime ReferenceDate { get; }

        string DoClassification();
    }
}
