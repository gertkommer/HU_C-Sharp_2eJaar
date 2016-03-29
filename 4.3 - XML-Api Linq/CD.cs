using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3___XML_Api_Linq
{
    class CD
    {
        public CD()
        {
            Tracks = new List<Track>();
        }
        public List<Track> Tracks {get;set;}
        public String Titel { get; set; }
        public String Artiest { get; set; }
    }
}
