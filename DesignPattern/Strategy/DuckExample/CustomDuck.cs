using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.DuckExample
{
    class CustomDuck : Duck
    {
        public CustomDuck(IQuackBehavior iQuackBehavior, IFlyBehavior iFlyBehavior) : base(iQuackBehavior, iFlyBehavior)
        {

        }
    }
}
