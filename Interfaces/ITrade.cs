using System;
using TradeClassification.Enums;
using TradeClassification.Model;

namespace TradeClassification.Interfaces
{
    public interface ITrade
    {
        string DoClassification(LineTrade _lineTrade);
    }
}
