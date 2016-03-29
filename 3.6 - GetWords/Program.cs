using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3._6___GetWords
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"..\..\randomtext.txt";
            Console.WriteLine("A");
            foreach (String word in GetWords(path, s => s.StartsWith("a")))
                Console.Write("{0}; ", word);
            Console.WriteLine("\nB");
            IEnumerable<String> e = GetWords(path, s => s.StartsWith("b"));
            String[] words = e.ToArray();
            Array.Sort(words, (s1, s2) => s1.CompareTo(s2));
            foreach (String word in words)
                Console.Write("{0}; ", word);

            Console.Read();

        }

        //static String[] GetWordsArray(String path, Func<String,bool> func){
        //    String f = File.ReadAllText(path);
        //    String[] words = f.Split();
        //    List<String> correctWords = new List<String>();
        //    foreach (String word in words)
        //    {
        //        if (func(word)) { correctWords.Add(word); }
        //    }
        //    String[] arr = correctWords.ToArray();
           
        //    Array.Sort(arr, (s1, s2) => s1.CompareTo(s2));
        //    return arr;           
        //}
        static IEnumerable<String> GetWords(String path, Func<String, bool> func)
        {
            if (File.Exists(path))
            {
                String f = File.ReadAllText(path);
                String[] words = f.Split();
                List<String> correctWords = new List<String>();
                foreach (String word in words)
                {
                    if (func(word)) { yield return word; }
                }
            }
            else
            {
                yield return "File does not exist.";
            }
        }
    }
}
