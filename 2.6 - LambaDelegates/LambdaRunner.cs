using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practicum2
{
    class LambdaRunner
    {
        public static String RunAllMethods(int num1, int num2, int num3)
        {
            StringBuilder output = new StringBuilder();

            // methode TimesThree herschreven als lambda-expressie
            Func<int, int> timesThree = x => 3 * x;
            output.AppendFormat("x => 3 * x, met x={0} = {1}\n", num1, timesThree(num1)); 

            //aanvullen
            Func<int, int, int, int> AddNumbers = (x, y, z) => x + y + z;
            output.AppendFormat("(x, y, z) => x + y + z, met x={0} en y={1} en z={2} = {3}\n", num1, num2, num3, AddNumbers(num1, num2, num3));
            
            Func<int,bool> IsEven = x => x % 2 == 0;
            output.AppendFormat("x => x % 2 == 0, met x={0} = {1}\n", num1, IsEven(num1)); 

            Func<int, String> numToString = x =>
            {
                switch (x)
                {
                    case 0:
                        return "zero";
                    case 1:
                        return "one";
                    case 2:
                        return "two";
                    case 3:
                        return "three";
                    case 4:
                        return "four";
                    case 5:
                        return "five";
                    case 6:
                        return "six";
                    case 7:
                        return "seven";
                    case 8:
                        return "eight";
                    case 9:
                        return "nine";
                    default:
                        return "undefined";
                }
            };
            output.AppendFormat("x => switch..., met x={0} = {1}\n", num1, numToString(num1)); 


            Func<int, int, int, bool> InBetween = (x, y, z) => x < y && y < z;
            output.AppendFormat("(x, y, z) => x < y && y < z, met x={0} en y={1} en z={2} = {3}\n", num1, num2, num3, InBetween(num1, num2, num3)); 


            Action<Person> ResetName = p =>  p.Name = null;
            Person p2 =  new Person();
            ResetName(p2);
            output.AppendFormat("p => {{ p.Name = null; return p.Name == null; }}; = {0}\n", p2.Name == null);


            return output.ToString();
        }

    }
}
