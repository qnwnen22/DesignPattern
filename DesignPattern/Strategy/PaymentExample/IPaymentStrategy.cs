using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.PaymentExample
{
    public interface IPaymentStrategy
    {
        void Pay(int amount);
    }
}
