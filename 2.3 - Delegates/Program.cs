using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3___Delegates
{
    class Program
    {
        public delegate int plusa(int a, int b);
        public static List<plusa> myList = new List<plusa>();
        static void Main(string[] args)
        {
            
            myList.Add(plus);
            myList.Add(vermenigvuldig);
            action(2,4);
            Console.Read();
        }

        public static void action(int a, int b)
        {
            foreach (plusa c in myList)
            {
                Console.WriteLine(c(a, b));
            }
        }
        static int plus(int a, int b)
        {
            return a + b;
        }

        public static int vermenigvuldig(int a, int b)
        {
            return a * b;
        }
    }
}
