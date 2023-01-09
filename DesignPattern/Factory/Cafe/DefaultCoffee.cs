using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.Cafe
{
    public class DefaultCoffee : Coffee
    {
        private int price;

        public DefaultCoffee()
        {
            this.price = -1;
        }
        public override int GetPrice()
        {
            return this.price;
        }
    }
}
