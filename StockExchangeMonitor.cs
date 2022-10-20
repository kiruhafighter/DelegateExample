using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateExample
{
    public class StockExchangeMonitor
    {
        public delegate void PriceChanger (int price);

        public PriceChanger PriceChangeHandler { get; set; }

        public void Start()
        {
            while (true)
            {
                int bankOfAmericaPrice = (new Random()).Next(70, 110);
                PriceChangeHandler(bankOfAmericaPrice);
                Thread.Sleep(2500);
            }
        }
                


    }
}
