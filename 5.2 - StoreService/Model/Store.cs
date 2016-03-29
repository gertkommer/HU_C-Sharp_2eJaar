using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace _5._2___StoreService.Model
{
    [DataContract]
    public class Store :IExtensibleDataObject
    {
        private ExtensionDataObject extensionDataObjectValue;
        public ExtensionDataObject ExtensionData
        {
            get
            {
                return extensionDataObjectValue;
            }
            set
            {
                extensionDataObjectValue = value;
            }
        }
        [DataMember]
        private List<User> users = new List<User>();
        [DataMember]
        private List<Product> products = new List<Product>();

        public Store() {
            User u = new User("admin");
            products.Add(new Product("Appel", 0.28, 200));
            products.Add(new Product("Peer", 0.45, 5));
            products.Add(new Product("Milka", 1.50, 20));
        }

        public void AddProduct(Product newProduct)
        {
            if(!products.Contains(newProduct))
            {
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

        public List<User> GetUsers()
        {
            return users;
        }

        public User GetUserByName(String s)
        {
            User u = null;
            foreach (User user in users)
            {
                if (user.username == s)
                {
                    u = user;
                }
            }
            return u;
        }
        
        public Product getProductByName(String s)
        {
            Product p = null;
            foreach (Product prod in products)
            {
                if (prod.name == s)
                {
                    p = prod;
                }
            }
            return p;
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
