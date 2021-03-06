﻿using TradeClassification.Model;

namespace TradeClassification.Interfaces
{
    public interface ITradeFactory
    {
        ITrade GetObjectTrade(LineTradeDTO trade);
    }
}
