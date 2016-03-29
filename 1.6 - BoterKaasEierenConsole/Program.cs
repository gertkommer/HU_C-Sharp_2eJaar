using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1._6___TicTacToeEngine;

namespace _1._6___BoterKaasEierenConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeEngine t = new TicTacToeEngine();

            while (true)
            {
                Console.Write(t.Board());
                String characters = Console.ReadLine();
                int n;
                if(int.TryParse(characters,out n)){
                    t.ChooseCell(n);
                    if (t.Status.ToString().Substring(t.Status.ToString().Length - 4) == "Wins")
                    {
                        Console.WriteLine("End of game. " + t.Status.ToString());
                        Console.WriteLine(t.Board());
                        Console.ReadLine();
                        t.ChooseCell(0);
                        Console.Clear();
                    }
                    else if (t.Status.ToString() == "Equal")
                    {
                        Console.WriteLine("End of game. Draw");
                        Console.WriteLine(t.Board());
                        Console.ReadLine();
                        t.ChooseCell(0);
                        Console.Clear();
                    }               
                }
                
            }
        }
    }
}
