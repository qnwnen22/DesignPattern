using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.PaymentExample
{
    public class Main
    {
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
