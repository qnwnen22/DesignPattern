using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Strategy
    {
        private interface IPaymentStrategy
        {
            void Pay(int amount);
        }

        private class KAKAOCard : IPaymentStrategy
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

        private class LUNACard : IPaymentStrategy
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

        private class Item
        {
            private string name;
            private int price;

            public Item(string name, int price)
            {
                this.name = name;
                this.price = price;
            }

            public string Name => name;
            public int Price => price;
        }

        private class ShoppingCart
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


        public static void Example()
        {
            KAKAOCard kakao = new KAKAOCard("Lee WonHyuck", "123456789", "123", "12/01");
            LUNACard luna = new LUNACard("qnwnen0228@gmail.com", "1234");

            var cart = new ShoppingCart();

            cart.AddItem(new Item("티셔츠", 15000));
            cart.AddItem(new Item("바지", 22000));

            cart.Pay(kakao);
            cart.Pay(luna);
        }
    }
}
