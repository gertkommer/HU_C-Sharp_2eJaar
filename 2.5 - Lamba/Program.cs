using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5___Lamba
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = (x, y) => x + y;
            Func<int, int, int> mul = (x, y) => x * y;

            int a = mul(add(4, 5), 10);

            Console.Write(a);
            Console.Read();
        }
    }
}
