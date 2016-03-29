using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using _5._1___ChatLibrary;

namespace _5._1___ChatHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ChatService)))
            {
                host.Open();

                Console.WriteLine("Service ready");
                Console.ReadKey();
            }
        }
    }
}
