using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB7
{
    internal class Product
    {
        private int currentPrice;
        private string name;
        private int mass;

        public int CurrentPrice
        {
            get { return currentPrice; }
            private set { currentPrice = WorldMarket.GetInitialPricePerKg(); }
        }

        public int Mass
        {
            get { return mass; }
            set
            {
                if (value >= 0)
                    mass = value;
            }
        }
    }
}
