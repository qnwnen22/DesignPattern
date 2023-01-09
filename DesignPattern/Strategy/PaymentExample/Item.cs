using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.PaymentExample
{
    public class Item
    {
        private string name;
        private int price;

        public Item(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name => name;
        public int Price => price;
    }
}
