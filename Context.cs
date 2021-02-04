using System;
using TradeClassification.Interfaces;
using TradeClassification.Model;

namespace TradeClassification
{
    public class Context 
    {
        private ITrade _trade;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public Context()
        {

        }

        /// <summary>
        /// Contrutor com parametros
        /// </summary>
        /// <param name="trade"></param>
        public Context(ITrade trade)
        {
            this._trade = trade;          
        }

        /// <summary>
        /// Método adicional com injeção alem do construtor
        /// </summary>
        /// <param name="trade"></param>
        public void SetTrade(ITrade trade)
        {
            this._trade = trade;
        }

        /// <summary>
        /// Realiza de execução do Strategy de acordo com as regras de negócio
        /// </summary>
        /// <param name="dataRef"></param>
        /// <param name="value"></param>
        /// <param name="clientSector"></param>
        /// <param name="nextPaymentDate"></param>
        public void DoBusinessLogic(DateTime dataRef, double value, string clientSector, DateTime nextPaymentDate)
        {
            ITrade trade = new TradeDefaulted(value, clientSector, nextPaymentDate, dataRef);

            if (value > 1000000.00)
            {
                switch (clientSector.ToUpper())
                {
                    case "PUBLIC":
                        this.SetTrade(new TradeMediumRisk(trade));                                            
                        break;
                    case "PRIVATE":
                        this.SetTrade(new TradeHighRisk(trade));                        
                        break;
                    default:
                        Console.WriteLine("Category not implemented");
                        break;
                }
            }
            else
            {
                var diffDataPayment = (dataRef - nextPaymentDate).TotalDays;
                if (diffDataPayment > 30)
                {
                    this.SetTrade(new TradeDefaulted(trade));
                }
                else
                {
                    Console.WriteLine("Category not implemented");
                }
            }

            Console.WriteLine(this._trade.ToString());
        }
    }
}
