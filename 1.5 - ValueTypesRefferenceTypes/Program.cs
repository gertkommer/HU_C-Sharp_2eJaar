using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypesRefferenceTypes
{
    class Program
    {
        struct MyStruct
        {
            public string StructName { get; set; }
            public MyStruct(string name):this()
            {
                this.StructName = name;
            }
        }

        static void Main()
        {
            MyStruct m = new MyStruct("name");
            ChangeStruct(ref m);
            Console.WriteLine(m.StructName);
            Console.Read();
        }

        static void ChangeStruct(ref MyStruct m)
        {
            m.StructName = "changed";
        }

    }
}
