using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Models
{
    public abstract class CoffeeDecorator : Coffee
    {
        protected readonly Coffee coffee;
        public CoffeeDecorator(Coffee coffee) 
        {
            this.coffee = coffee;
        }
    }
}
