using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Factory
    {
        private enum CoffeeType
        {
            Default,
            Americano,
            Latte
        }

        private abstract class Coffee
        {
            public abstract int GetPrice();
            public string GetInfo()
            {
                return $"name : {GetType().Name}\nprice : {GetPrice()}";
            }
        }

        private class DefaultCoffee : Coffee
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

        private class Latte : Coffee
        {
            private int price;

            public Latte(int price)
            {
                this.price = price;
            }
            public override int GetPrice()
            {
                return this.price;
            }
        }

        private class Americano : Coffee
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

        private class CoffeeFactory
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


        public static void Example()
        {
            Coffee latte = CoffeeFactory.GetCoffee(CoffeeType.Latte, 4000);
            Coffee americano = CoffeeFactory.GetCoffee(CoffeeType.Americano, 1000);
            Coffee defaultCoffee = CoffeeFactory.GetCoffee(CoffeeType.Default, 0);

            List<Coffee> coffees = new List<Coffee>() {
                latte,
                americano,
                defaultCoffee
            };

            foreach (Coffee coffee in coffees)
            {
                string info = coffee.GetInfo();
                Console.WriteLine(info);
            }

        }

    }
}
