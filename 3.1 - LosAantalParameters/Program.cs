using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1___LosAantalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = TelOp();
            int y = TelOp(1);
            int z = TelOp(1, 2);
            int u = TelOp(10, 11, 12);
            int som = TelOp(x, y, z, u);
            Console.Write(x + " + " + y + " + " + z + " + " + u + " = " + som);
            Console.Read();

        }

        static int TelOp(params int[] args){
            int result = 0;
            foreach (int i in args)
            {
                result += i;
            }
            return result;
        }
    }
}
