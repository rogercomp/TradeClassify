using System;
using TradeClassification.Model;

namespace TradeClassification
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = 0;
            try
            {               
                if (args.Length > 0)
                {
                    DateTime dataRef = DateTime.Parse(args[0]);
                    line++;
                    int n = int.Parse(args[1]);
                    line++;
                    for (int i = 2; i < (n + 2); i++)
                    {
                        string[] tradeLine = args[i].Split(" ");
                        double value = Double.Parse(tradeLine[0]);
                        string clientSector = tradeLine[1];
                        DateTime nextPaymentDate = DateTime.Parse(tradeLine[2]);
                        var context = new Context(new TradeFactory());
                        context.DoBusinessLogic(new LineTradeDTO( value, clientSector, nextPaymentDate, dataRef));
                        line++;
                    }
                }
                else
                {
                    Console.WriteLine("No command line arguments found.");
                }
            }catch (Exception e)
            {
                Console.WriteLine("Error reading information in line {0} . Please check! - " + e.Message, line);
            }
        }
    }
}
