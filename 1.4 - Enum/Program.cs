using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum Days {zondag, maandag, dinsdag, woensdag, donderdag, vrijdag, zaterdag};
        static void Main(string[] args)
        {
            Days myDay = Days.maandag;
            Days myDay2 = Days.vrijdag;
            leSwitch(myDay);
            leSwitch(myDay2);
            
            Console.Read();
        }

        private static void leSwitch(Days myDay){
            switch (myDay)
            {
                case Days.zondag: Console.WriteLine("zondag"); break;
                case Days.maandag: Console.WriteLine("maandag"); break;
                case Days.dinsdag: Console.WriteLine("dinsdag"); break;
                case Days.woensdag: Console.WriteLine("woensdag"); break;
                case Days.donderdag: Console.WriteLine("donderdag"); break;
                case Days.vrijdag: Console.WriteLine("vrijdag"); break;
                case Days.zaterdag: Console.WriteLine("zaterdag"); break;
            }
        }
    }
}
