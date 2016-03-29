using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace _5._2___StoreService.Model
{
    [DataContract]
    public class Product : IExtensibleDataObject
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
        public string name { get; set; }
        [DataMember]
        public double price { get; set; }
        [DataMember]
        public int stock { get; set; }

        public Product(string p1, double p2, int p3)
        {
            // TODO: Complete member initialization
            this.name = p1;
            this.price = p2;
            this.stock = p3;
        }
        public String toString()
        {
            return this.name + " €" + this.price + " , " + this.stock; 
        }
    }
}
