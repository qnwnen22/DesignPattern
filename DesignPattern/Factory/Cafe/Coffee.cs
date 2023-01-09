using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.Cafe
{
    public abstract class Coffee
    {
        public abstract int GetPrice();
        public string GetInfo()
        {
            return $"name : {GetType().Name}\nprice : {GetPrice()}";
        }
    }
}
