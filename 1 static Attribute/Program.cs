using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_static_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static attribute is a shows all
            //its an attribute on the class itself
            Songs holiday = new Songs("Holiday", "Green Day", 6);
            Songs Kashmir = new Songs("Kashmir", "Led Zeppelin", 7);
            Songs gospel = new Songs("Gospel", "Vuyo Mokoena", 4);

            Console.WriteLine(Songs.songCount);
            Console.ReadLine();
        }
    }
    internal class Songs
    {
        public string title;
        public string artist;
        public int duration;

        public static int songCount = 0;//declaration of the songCount
        public Songs(string aTitle, string aArtist, int aDuration)
        {
            this.title = aTitle;
            this.artist = aArtist;
            this.duration = aDuration;
            songCount++;//increment
        }
    }
}
