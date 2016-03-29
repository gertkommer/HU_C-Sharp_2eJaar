using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5___IEnumerable2
{
    class Program
    {
        static void Main(string[] args)
        {
            RekenReeks r = new RekenReeks(2, n => n * 2);

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
