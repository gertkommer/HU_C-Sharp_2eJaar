using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextUtil;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            String normal = "camel cased string";
            String camelCased = MyTextUtil.CamelCase(normal);
            Console.WriteLine(camelCased);
            String unCamelCased = MyTextUtil.UnCamelCase(camelCased);
            Console.WriteLine(unCamelCased);
            Console.Read();
        }
    }
}
