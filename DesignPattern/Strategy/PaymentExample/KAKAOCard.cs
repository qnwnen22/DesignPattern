using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.PaymentExample
{
    public class KAKAOCard : IPaymentStrategy
    {
        private string name;
        private string cardNumber;
        private string cvv;
        private string dateOfExpiry;

        public KAKAOCard(string name, string cardNumber, string cvv, string dateOfExpiry)
        {
            this.name = name;
            this.cardNumber = cardNumber;
            this.cvv = cvv;
            this.dateOfExpiry = dateOfExpiry;
        }

        public void Pay(int amount)
        {
            Console.WriteLine($"{amount} paid using KAKAOCard.");
        }
    }
}
