using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.Cafe
{
    public class Americano : Coffee
    {
        private int price;

        public Americano(int price)
        {
            this.price = price;
        }
        public override int GetPrice()
        {
            return this.price;
        }
    }
}
