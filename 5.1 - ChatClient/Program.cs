using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5._1___ChatClient.ChatService;

namespace _5._1___ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (ChatServiceClient chatProxy = new ChatServiceClient())
            //{
            //    chatProxy.PostNote("Gert", "Hello again");
            //    Console.ReadKey();
            //}

            ChatServiceClient chatProxy = new ChatServiceClient();

            Console.WriteLine("Please enter your name:");
            String name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Type a note (or hit enter to quit):");
                String note = Console.ReadLine();
                if (String.IsNullOrEmpty(note))
                {
                    break;
                }
                chatProxy.PostNote(name, note);
            }
        }
    }
}
