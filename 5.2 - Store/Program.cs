using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2___Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();
            Product p1 = new Product("Apple", 3.54, 5);
            Product p2 = new Product("Egg", 2.86, 7);
            s.addProduct(p1);
            s.addProduct(p2);
            User u1 = new User("Piet");

            Console.WriteLine("test");
            Console.ReadKey();
        }
    }
}
