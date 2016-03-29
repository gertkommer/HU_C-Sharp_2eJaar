using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3___IComparable
{
    class Product : IComparable<Product>
    {
        public Product(double price){
            this.Price = price;
        }
        public double Price { get; set;}

        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}
