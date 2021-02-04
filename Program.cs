using System;

namespace TradeClassification
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                DateTime dataRef = DateTime.Parse(args[0]);
                int n = int.Parse(args[1]);

                for (int i = 2; i < (n + 2); i++)
                {
                    string[] tradeLine = args[i].Split(" ");
                    double value = Double.Parse(tradeLine[0]);
                    string clientSector = tradeLine[1];
                    DateTime nextPaymentDate = DateTime.Parse(tradeLine[2]);
                    var context = new Context();
                    context.DoBusinessLogic(dataRef, value, clientSector, nextPaymentDate);
                }
            }
            else
            {
                Console.WriteLine("No command line arguments found.");
            }           
        }
    }
}
