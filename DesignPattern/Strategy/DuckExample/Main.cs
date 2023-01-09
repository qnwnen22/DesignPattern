using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.DuckExample
{
    public class Main
    {
        public static void Example()
        {
            var WoodDuck = new DesignPattern.Strategy.DuckExample.CustomDuck(
                new DesignPattern.Strategy.DuckExample.MuteQuack(),
                new DesignPattern.Strategy.DuckExample.FlyNoWay()
            );

            WoodDuck.Quack();
            WoodDuck.Fly();
        }
    }
}
