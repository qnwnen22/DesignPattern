using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.DuckExample
{
    class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak.Quack() : 고무오리 꽥꽥");
        }
    }
}
