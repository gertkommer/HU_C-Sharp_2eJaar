using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Diagnostics;

namespace _5._1___ChatLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ChatService" in both code and config file together.
    public class ChatService : IChatService
    {
        public void PostNote(string from, string note)
        {
            Console.WriteLine("{0}: {1}", from, note);
        }
    }
}
