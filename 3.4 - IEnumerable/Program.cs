using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4___IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Reeks r = new Reeks();

            foreach (int i in r)
            {
                
                if (i > 1000)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
