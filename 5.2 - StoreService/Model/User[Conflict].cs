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
            saldo = 15;
        }

        public String reverse(String s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public void addToProducts(Product p)
        {

            products.Add(p, 1);
        }

        public void buyProduct(Product productToBuy)
        {
            if (productToBuy.price < saldo)
            {
                if (productToBuy.stock > 0)
                {
                    productToBuy.stock -= 1;
                    addToProducts(productToBuy);
                }
                else
                {
                    Console.WriteLine("This product isn't in stock at the moment.");
                }
            }
            else
            {
                Console.WriteLine("You don't have enough money for this product.");
            }
        }
    }
}

