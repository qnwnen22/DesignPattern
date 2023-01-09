using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.DuckExample
{
    class Duck
    {
        protected IQuackBehavior IQuackBehavior { get; set; }
        protected IFlyBehavior IFlyBehavior { get; set; }

        protected Duck(IQuackBehavior iQuackBehavior, IFlyBehavior iFlyBehavior)
        {
            IQuackBehavior = iQuackBehavior;
            IFlyBehavior = iFlyBehavior;
        }

        public virtual void Quack()
        {
            IQuackBehavior.Quack();
        }

        public virtual void Fly()
        {
            IFlyBehavior.Fly();
        }
    }
}
