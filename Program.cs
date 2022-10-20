using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public class Program
    {
        public delegate void Stndart();

        static void Main(string[] args)
        {
            StockExchangeMonitor stockExchangeMonitor = new StockExchangeMonitor();
            stockExchangeMonitor.PriceChangeHandler = ShowPrice;
            stockExchangeMonitor.Start();


        }

        public static void ShowPrice(int price)
        {
            Console.WriteLine($"New price is : {price}");
        }
    }
}
