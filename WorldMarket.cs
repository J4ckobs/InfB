using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB7
{
    internal class WorldMarket
    {
        public static int GetInitialPricePerKg()
        {
            Random r = new Random();
            Console.WriteLine(r.Next(100, 1001));
            return r.Next(100,1001);
        }

        public static int GetNewPricePerKg(int a)
        {
            Random r = new Random();

            return 0; ////////
        
    }
}
