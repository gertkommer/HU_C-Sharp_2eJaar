using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("iPad", 499);
            Product p2 = new Product("iPad", 89);
            Product[] products = { p1, p2 };


            foreach (Product p in products)
            {
                Console.WriteLine("Product " + p.Name + " kost " + p.PriceInEuros + " euro en " + p.PriceInDollars + " dollar");
            }
            Console.Read();
        }
    }
}
//	twee objecten van class Product die je verzamelt in een array
//	laat  de naam en beide prijzen van beide producten zien middels een foreach loop, zodat de volgende output verschijnt: 
