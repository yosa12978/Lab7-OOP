using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Models
{
    public class CoffeeBuilder
    {
        private Coffee coffee;

        public CoffeeBuilder()
        {
            this.coffee = new Coffee();
        }

        public Coffee Build()
        {
            return coffee;
        }

        public CoffeeBuilder AddEspressoShot()
        {
            this.coffee.EspressoShots++;
            return this;
        }

        public CoffeeBuilder RemoveEspressoShot()
        {
            if (this.coffee.EspressoShots <= 1) return this;
            this.coffee.EspressoShots--;
            return this;
        }

        public CoffeeBuilder AddMilk()
        {
            this.coffee.Milk = true;
            return this;
        }

        public CoffeeBuilder RemoveMilk()
        {
            this.coffee.Milk = false;
            return this;
        }
    }
}
