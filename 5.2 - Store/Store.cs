using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2___Store
{
    class Store
    {
        private List<User> users = new List<User>();
        private List<Product> products = new List<Product>();

        public void addProduct(Product newProduct)
        {
            if(!products.Contains(newProduct)){
                products.Add(newProduct);
            }
            else
            {
                Console.WriteLine("Product already exist");
            }
        }

        public void removeProduct(Product productToRemove)
        {
            if (products.Contains(productToRemove))
            {
                products.Remove(productToRemove);
            }
            else
            {
                Console.WriteLine("Product doesn't exist");
            }
        }

        public Boolean buyProduct(Product productToBuy)
        {
            bool b = false;
            if (products.Contains(productToBuy))
            {
                if (productToBuy.stock > 0)
                {
                    b = true;
                    productToBuy.stock -= 1;
                }
                else
                {
                    Console.WriteLine("This product isn't in stock at the moment.");
                }
            }
            else
            {
                Console.WriteLine("Product doensn't exist.");
            }
            return b;
        }

        public void addUser(User newUser)
        {
            if (!users.Contains(newUser))
            {
                users.Add(newUser);
            }
            else
            {
                Console.WriteLine("User already exist");
            }
        }

        public void removeUser(User userToRemove)
        {
            if (users.Contains(userToRemove))
            {
                users.Remove(userToRemove);
            }
            else
            {
                Console.WriteLine("User doesn't exist");
            }
        }
    }
}
