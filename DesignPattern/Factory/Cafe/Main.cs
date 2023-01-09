using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.Cafe
{
    public class Main
    {
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
