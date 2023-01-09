using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.PaymentExample
{
    public class LUNACard : IPaymentStrategy
    {
        private string email;
        private string password;

        public LUNACard(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public void Pay(int amount)
        {
            Console.WriteLine($"{amount} paid using LUNACard.");
        }
    }
}
