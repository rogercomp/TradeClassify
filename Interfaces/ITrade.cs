using System;
using TradeClassification.Enums;

namespace TradeClassification.Interfaces
{
    public interface ITrade
    {
        double Value { get;  }
        string ClientSector { get;  }
        DateTime NextPaymentDate { get;  }
        DateTime RefDate { get; }
        Classification TradeClassify { get; set; }

        public void DoClassification();
                
    }
}
