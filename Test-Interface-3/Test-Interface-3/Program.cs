using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFile m1 = new MusicFile("Believer", "Imagine Dragon", 2017, 204);
            MusicFile m2 = new MusicFile("Boulevard Of Broken Dreams", "Green Day", 2004, 260);
            Phone phone = new MusicPlayer("Music Player", m1);
            phone.addMusic(m1, m2);
            phone.play(true);
            phone.playNext();

            Console.WriteLine();
            Console.WriteLine();

            Phone radio = new RadioPlayer("Radio Player", 89.5);
            radio.play(true);
            radio.playNext();
        }
    }
}
