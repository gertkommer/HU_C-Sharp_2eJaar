using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2___Store
{
    class User
    {
        public String username { get; set; }
        public String password { get; set; }
        public double saldo { get; set; }
        public Dictionary<Product, int> products;
        
        public User() { }

        public User(String user)
        {
            username = user;
            password = reverse(user);
            saldo = 15;
        }

        public String reverse(String s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public void buyProduct(Product productToBuy)
        {
            if (productToBuy.price < saldo)
            {
                if()
            }
            else
            {
                Console.WriteLine("You don't have enough money for this product.");
            }
        }
    }
}

