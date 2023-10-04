using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Models
{
    public interface PaymentStrategy
    {
        void Pay(double amount);
    }
}
