using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2___Split
{
    class Program
    {
        static void Main(string[] args)
        {
            String lorem = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";
            String[] words = lorem.Split(' ');
            //String FirstAWord = words.AsEnumerable().First(word => word.ElementAt(0) == 'a');
            String FirstAWord = Array.Find<String>(words, word => word.StartsWith("a"));
            Console.WriteLine(FirstAWord);

            Console.WriteLine();

            //String[] AWords = words.AsEnumerable().Where(word => word.ElementAt(0) == 'a').ToArray();
            String[] AWords = Array.FindAll<String>(words, word => word.StartsWith("a"));
            foreach (String s in AWords)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Total words that start with an a: " + AWords.Length);

            Console.WriteLine();

            //int DrieOfKorter = (words.AsEnumerable().Sum(word => word.Length <= 3 ? 1 : 0));
            int KorterDanDrie = Array.FindAll<String>(words, word => word.Length < 3).Length;

            Console.WriteLine("Total words smaller than 3: " + KorterDanDrie);
            Console.Read();
        }
    }
}
