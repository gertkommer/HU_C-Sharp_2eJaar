using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _4._3___XML_Api_Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            
            CD mijnCD = new CD();
            mijnCD.Titel = "Divenire";
            mijnCD.Artiest = "Ludovico Einaudi";
            
            
            Track t1 = new Track();
            t1.Titel = "Uno";
            t1.Artiest = mijnCD.Artiest;
            t1.Lengte = new TimeSpan(0,3,47);
            mijnCD.Tracks.Add(t1);

            Track t2 = new Track();
            t2.Titel = "Divenire";
            t2.Artiest = mijnCD.Artiest;
            t2.Lengte = new TimeSpan(0,6,42);
            mijnCD.Tracks.Add(t2);

            Track t3 = new Track();
            t3.Titel = "Monday";
            t3.Artiest = mijnCD.Artiest;
            t3.Lengte = new TimeSpan(0,5,55);
            mijnCD.Tracks.Add(t3);

            var cdXml = printxml(mijnCD);

            String xmlString;
            using (WebClient wc = new WebClient())
            {
                xmlString = wc.DownloadString(@"http://ws.audioscrobbler.com/2.0/?method=album.getinfo&api_key=0a94c432e0eacbf27406c08ebd67b674&artist=Ludovico%20Einaudi&album=divenire");
            }
            XDocument myXMLDoc = XDocument.Parse(xmlString);

            var tracksNietInMijnCD = from track in myXMLDoc.Element("lfm").Element("album").Element("tracks").Elements("track")
                                     where !(from track2 in cdXml.Element("CD").Element("Tracks").Elements("Track") select track2.Element("Title").Value).Contains(track.Element("name").Value)
                                     select track;

            foreach (XElement x in tracksNietInMijnCD)
            {
                
                Track t = new Track();
                String trackTitle = x.Element("name").Value;
                String trackArtist = x.Element("artist").Element("name").Value;
                String trackLengthS = x.Element("duration").Value;
                TimeSpan trackLength = new TimeSpan(0 , 0 , Int32.Parse(trackLengthS));
                t.Titel = trackTitle;
                t.Artiest = trackArtist;
                t.Lengte = trackLength;
                mijnCD.Tracks.Add(t);
            }

            printxml(mijnCD);
            Console.Read();
                                     
        }
        public static XDocument printxml(CD mijnCD)
        {
            XDocument mijnXml = new XDocument();

            var cdElem = new XElement("cd");
            var cdTitelElem = new XAttribute("title", mijnCD.Titel);
            var cdArtiestElem = new XAttribute("artist", mijnCD.Artiest);
            var cdTracksElem = new XElement("tracks");

            cdElem.Add(cdTitelElem);
            cdElem.Add(cdArtiestElem);
            cdElem.Add(cdTracksElem);
            foreach (Track eenTrack in mijnCD.Tracks)
            {
                var cdTrackElem = new XElement("track");
                var cdTrackTitelElem = new XElement("title", eenTrack.Titel);
                var cdTrackArtiestElem = new XElement("artist", eenTrack.Artiest);
                var cdTrackLengteElem = new XElement("length", eenTrack.Lengte.ToString());

                cdTrackElem.Add(cdTrackTitelElem);
                cdTrackElem.Add(cdTrackArtiestElem);
                cdTrackElem.Add(cdTrackLengteElem);

                cdTracksElem.Add(cdTrackElem);

            }

            mijnXml.Add(cdElem);

            Console.WriteLine(mijnXml.ToString());
            Console.WriteLine();
            //Console.Read();
            var cdXml = new XDocument(new XElement("CD",
                    new XAttribute("Title", mijnCD.Titel),
                    new XAttribute("Artist", mijnCD.Artiest),
                    new XElement("Tracks",
                        from track in mijnCD.Tracks
                        select new XElement("Track",
                            new XElement("Title", track.Titel),
                            new XElement("Artist", track.Artiest),
                            new XElement("Length", track.Lengte.ToString())
                        )
                    )
                )
            );

            Console.WriteLine(cdXml.ToString());
            Console.Read();
            return cdXml;
        }
    }
}