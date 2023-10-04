using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Models
{
    public class OnlinePayment : PaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid online: {amount}$");
        }
    }
}
