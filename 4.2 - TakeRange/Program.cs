using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2___TakeRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Reeks r = new Reeks();
            IEnumerable<int> selectie = r.TakeRange(10, 1000);
            foreach (int j in selectie)
            {
                Console.WriteLine(j);
            }
            
            Console.Read();
        }
    }
    static class leExtension
    {
        public static IEnumerable<int> TakeRange(this Reeks r, int a, int b)
        {
            return r.TakeWhile(s => s < b).SkipWhile(s => s < a);
        }
    }
}
