using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.PaymentExample
{
    public class ShoppingCart
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        public int CalculateTotal()
        {
            int result = 0;
            foreach (var item in items)
            {
                result += item.Price;
            }
            return result;
        }

        public void Pay(IPaymentStrategy paymentStrategy)
        {
            int amount = CalculateTotal();
            paymentStrategy.Pay(amount);
        }
    }
}
