using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextUtil
{
    class MyTextUtil
    {
        public static String CamelCase(String s)
        {
            String[] words = s.Split(' ');
            String returnString = "";
            foreach(String s2 in words){
                returnString += (char.ToUpper(s2[0]) + s2.Substring(1));
            }
            return returnString;
        }

        public static String UnCamelCase(String s)
        {
            String returnString = "";
            foreach(char c in s){
                if(char.IsUpper(c)){
                    returnString += ((returnString.Length == 0) ? "": " ") + char.ToLower(c);
                }else{
                    returnString += c;
                }
            }
            return returnString;
        }
    }
}
