using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Models
{
    internal class Order
    {
        public List<Coffee> items { get; set; }
        public double total { get; set; }
        public PaymentStrategy paymentStrategy { get; set; }
        public string orderId { get; private set; }
        public bool Paid { get; set; }

        public Order()
        {
            orderId = Guid.NewGuid().ToString();
            Paid = false;
            items = new List<Coffee>();
            total = 0;
            paymentStrategy = new CashPayment();
        }

        public void AddItem(Coffee coffee)
        {
            items.Add(coffee);
            total += coffee.GetPrice();
        }

        public void RemoveItem(Coffee coffee)
        {
            items.Remove(coffee);
            total -= coffee.GetPrice();
        }

        public void Pay()
        {
            if (Paid)
            {
                Console.WriteLine("This order is already paid");
                return;
            }
            paymentStrategy.Pay(total);
            Paid = true;
            Console.WriteLine($"Your order id is {orderId}.\r\nCome and grab your coffee.\r\n");
        }

        public void SetPaymentStrategy(PaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }
    }
}
