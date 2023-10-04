using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Models
{
    public class Coffee
    {
        public int EspressoShots { get; set; }
        public bool Milk { get; set; }
        public Coffee() 
        {
            this.EspressoShots = 1;
            this.Milk = false;
        }
        public virtual string GetName()
        {
            string milk = Milk ? "with" : "without";
            return $"Coffee {milk} milk and {EspressoShots} espresso shot(s)";
        }
        public virtual double GetPrice()
        {
            return (double)EspressoShots * 1.5d + (1.5d * (Milk ? 1d : 0d));
        }
        public override string ToString()
        {
            return $"Name: {this.GetName()}\r\nPrice: {this.GetPrice()}$\r\n";
        }
    }
}
