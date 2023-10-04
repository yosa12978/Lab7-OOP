using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Models
{
    public class Chocolate : CoffeeDecorator
    {
        public Chocolate(Coffee coffee) : base(coffee) { }

        public override string GetName()
        {
            return $"{this.coffee.GetName()}, Chocolate";
        }

        public override double GetPrice()
        {
            return this.coffee.GetPrice() + .49d;
        }
    }
}
