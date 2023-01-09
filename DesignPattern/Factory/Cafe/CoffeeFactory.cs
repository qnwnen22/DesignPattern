using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.Cafe
{
    public class CoffeeFactory
    {
        public static Coffee GetCoffee(CoffeeType coffeeType, int price)
        {
            Coffee resultCoffee = null;
            switch (coffeeType)
            {
                case CoffeeType.Americano:
                    resultCoffee = new Americano(price);
                    break;
                case CoffeeType.Latte:
                    resultCoffee = new Latte(price);
                    break;

                case CoffeeType.Default:
                default:
                    resultCoffee = new DefaultCoffee();
                    break;
            }
            return resultCoffee;
        }
    }
}
