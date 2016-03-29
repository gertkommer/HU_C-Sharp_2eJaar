using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Product
    {
        public Product(String name, double dollars)
        {
            this.Name = name;
            this.PriceInDollars = dollars;
        }
        public String Name { get; set; }
        public double PriceInDollars { get; private set; }
        public double PriceInEuros{
            get{
                return PriceInDollars * 0.75;
            }
        }

        
    }
}
