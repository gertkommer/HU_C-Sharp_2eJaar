using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using _5._2___StoreService.Model;

namespace _5._2___StoreService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StoreService" in both code and config file together.
    public class StoreService : IStoreService
    {
        private static Store theStore = new Store();
        public List<Product> GetProducts()
        {
            return theStore.GetProducts();
            
        }

        public void AddProduct(string pname, double pPrice, int stock)
        {
            Product newProduct = new Product(pname, pPrice, stock);
            theStore.AddProduct(newProduct);
        }

        public String AddProductToInventory(User buyer, Product product)
        {
            Product p = theStore.getProductByName(product.name);
            User u = theStore.GetUserByName(buyer.username);
            return u.buyProduct(p, theStore);
        }

        public Dictionary<Product, int> getInventory(User buyer)
        {
            return theStore.GetUserByName(buyer.username).products;
        }

        public Product getProductByName(String s)
        {
            return theStore.getProductByName(s);
        }

        public User GetUserByName(String s)
        {
            return theStore.GetUserByName(s);
        }

        public Boolean Register(String username)
        {
            Boolean unique = true;
            foreach (User u in theStore.GetUsers())
            {
                if (u.username.Equals(username))
                {
                    unique = false;
                    break;
                }
            }

            if (unique)
            {
                User newUser = new User(username);
                theStore.addUser(newUser);
            }
            return unique;
        }

        public User Login(String username, String password)
        {
            foreach (User u in theStore.GetUsers())
            {
                if (username.Equals(u.username) && password.Equals(u.password))
                {
                    return u;
                }
            }
            return null;
        }
    }
}
