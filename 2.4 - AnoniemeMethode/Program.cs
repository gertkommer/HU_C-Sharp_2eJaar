using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4___AnoniemeMethode
{
    class Program
    {
        public static List<Action<int, int>> myList = new List<Action<int, int>>();
        static void Main(string[] args)
        {

            myList.Add(delegate(int a, int b){
                Console.WriteLine(a + " + " + b + " = " + (a + b));
            });
            myList.Add(delegate(int a, int b)
            {
                Console.WriteLine(a + " * " + b + " = " + (a * b));
            });
            action(2, 4);
            Console.Read();
        }

        public static void action(int a, int b)
        {
            foreach (Action<int,int> c in myList)
            {
                c(a,b);
            }
        }
    }
}
