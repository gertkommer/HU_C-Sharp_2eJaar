using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _5._2___Store
{
    
    public class Product
    {
        
        public string name { get; set; }
        public double price { get; set; }
        public int stock { get; set; }

        public Product(string p1, double p2, int p3)
        {
            // TODO: Complete member initialization
            this.name = p1;
            this.price = p2;
            this.stock = p3;
        }

    }
}
