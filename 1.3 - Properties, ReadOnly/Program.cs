using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesReadOnly
{
    class Program
    {
        void Main()
        {
            MyObject o1 = new MyObject();
            Thread.Sleep(1000);
            MyObject o2 = new MyObject();
            Console.WriteLine("o1 was created: {0} and o2 was created: {1}",
                            o1.Created, o2.Created);
            Console.WriteLine("o1 was created: {0} and o2 was created: {1}",
                            o1.created, o2.created);
        }

        class MyObject
        {
            public MyObject()
            {
                _created = DateTime.Now;
                created = DateTime.Now;
            }

            private DateTime _created;
            public readonly DateTime created;

            public DateTime Created
            {
                get
                {
                    _created = DateTime.Now;
                    return _created;
                }
            }
        }

    }
}


// _created word opniew geset met de huidige datum tijd ipv dat de opgeslagen informatie word opgehaald uit created