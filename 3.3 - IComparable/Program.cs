using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3___IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1);
            Product p2 = new Product(1.5);
            Product p3 = new Product(1.2);
            Product[] products = { p1, p2, p3 };

            //Product[] orderedArray = (from Product in products orderby Product.Price select Product).ToArray();
            Array.Sort(products);
            foreach (Product p in products)
            {
                Console.WriteLine(p.Price);
            }

            Console.WriteLine();

            //Product[] orderedArray2 = products.OrderBy(p => p.Price).ToArray();
            Array.Sort(products, (x, y) => y.CompareTo(x));
            foreach (Product p in products)
            {
                Console.WriteLine(p.Price);
            }

            Console.Read();
        }
    }
}
