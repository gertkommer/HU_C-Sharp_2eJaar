using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace _5._2___StoreService.Model
{
    [DataContract]
    public class User : IExtensibleDataObject
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
        public String username { get; set; }
        [DataMember]
        public String password { get; set; }
        [DataMember]
        public double saldo { get; set; }
        [DataMember]
        public Dictionary<Product, int> products;
        
        public User() { }

        public User(String user)
        {
            username = user;
            password = reverse(user);
            saldo = 10;
            products = new Dictionary<Product, int>();
        }

        public Dictionary<Product, int> getInventory()
        {
            return products;
        }

        public String reverse(String s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public void addToProducts(Product product, Store store)
        {
            Product p = store.getProductByName(product.name);
            if (products.Count != 0)
            {
                bool b = false;
                foreach (KeyValuePair<Product, int> entry in products)
                {
                    Product prod = entry.Key;
                    if (prod.name == p.name)
                    {
                        b = true;
                        break;
                    }
                }
                if(b == false)
                {
                    products.Add(p, 1);
                }
                else
                {
                    foreach (KeyValuePair<Product, int> entry in products)
                    {
                        Product prod = entry.Key;
                        if (prod.name == product.name)
                        {
                            products[prod] += 1;
                            break;
                        }
                    }
                }
            }
            else
            {
                products.Add(p, 1);
            }
        }

        public String buyProduct(Product productToBuy, Store store)
        {
            Product p = store.getProductByName(productToBuy.name);
            if (p.price < saldo)
            {
                if (p.stock > 0)
                {
                    p.stock -= 1;
                    addToProducts(p, store);
                    saldo -= p.price;
                    return "You've bought succesfully a " + p.name;
                }
                else
                {
                    return "This product isn't in stock at the moment.";
                }
            }
            else
            {
                return "You don't have enough money for this product.";
            }
            
        }
    }
}

