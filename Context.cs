using System;
using System.Collections.Generic;
using TradeClassification.Interfaces;
using TradeClassification.Model;

namespace TradeClassification
{
    public class Context 
    {
        private ITradeFactory _tradeFactory;

        public Context()
        {
          
        }

        public Context(ITradeFactory tradeFactory)
        {
            _tradeFactory = tradeFactory;
        }

        List<LineTrade> _linesTrade = new List<LineTrade>();

        public void DoBusinessLogic(LineTrade _lineTrade)
        {
            ITrade trade = _tradeFactory.GetObjectTrade(_lineTrade);
            Console.WriteLine(trade.DoClassification(_lineTrade));
        }
    }
}
