using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using _5._2___StoreService.Model;

namespace _5._2___StoreService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStoreService" in both code and config file together.
    [ServiceContract]
    public interface IStoreService
    {
        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        void AddProduct(String pName, double pPrice, int pStock);

        [OperationContract]
        String AddProductToInventory(User buyer, Product product);

        [OperationContract]
        Dictionary<Product, int> getInventory(User buyer);

        [OperationContract]
        Product getProductByName(String s);

        [OperationContract]
        User GetUserByName(String s);
        
        [OperationContract]
        Boolean Register(String username);

        [OperationContract]
        User Login(String username, String password);
    }
}
