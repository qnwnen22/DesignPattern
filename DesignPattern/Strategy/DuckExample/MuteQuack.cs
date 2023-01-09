using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.DuckExample
{
    class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("MuteQuack.Quack() : ...");
        }
    }
}
