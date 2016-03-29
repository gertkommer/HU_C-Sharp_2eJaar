using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1___LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            Reeks r = new Reeks();

            var q = r.SkipWhile(r1 => r1 < 10).TakeWhile(r1 => r1 < 1000);

            /*var q = from r1 in r
                    where r1 > 0 && r1 < 1000
                    select r1;*/
            foreach (int j in q)
            {
                Console.WriteLine(j);
            }
            Console.Read();
        }
    }
}
