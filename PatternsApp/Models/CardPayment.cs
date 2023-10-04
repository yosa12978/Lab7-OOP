using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Models
{
    public class CardPayment : PaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid with card: {amount}$");
        }
    }
}
