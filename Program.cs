using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5_1302204026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo v = new SayaTubeVideo("Review Film snowden oleh ADHA SURYA DWIKA");
            SayaTubeVideo v1 = new SayaTubeVideo("Review Film snowman oleh ADHA SURYA DWIKA");
            SayaTubeVideo v2 = new SayaTubeVideo("Review Film snowdin oleh ADHA SURYA DWIKA");
            SayaTubeVideo v3 = new SayaTubeVideo("Review Film snowjamal oleh ADHA SURYA DWIKA");
            SayaTubeVideo v4 = new SayaTubeVideo("Review Film snowridho oleh ADHA SURYA DWIKA");
            SayaTubeVideo v5 = new SayaTubeVideo("Review Film magic broom oleh ADHA SURYA DWIKA");
            SayaTubeVideo v6 = new SayaTubeVideo("Review Film magic galon oleh ADHA SURYA DWIKA");
            SayaTubeVideo v7 = new SayaTubeVideo("Review Film magic bottle oleh ADHA SURYA DWIKA");
            SayaTubeVideo v8 = new SayaTubeVideo("Review Film magic wibu oleh ADHA SURYA DWIKA");
            SayaTubeVideo v9 = new SayaTubeVideo("Review Film magic ash oleh ADHA SURYA DWIKA");

            SayaTubeUser vv = new SayaTubeUser("ADHA SURYA DWIKA");
            v.increasePlayCount(1);
            v1.increasePlayCount(7);
            v2.increasePlayCount(5);
            vv.AddVideo(v);
            vv.AddVideo(v1);
            vv.AddVideo(v2);
            vv.AddVideo(v3);
            vv.AddVideo(v4);
            vv.AddVideo(v5);
            vv.AddVideo(v6);
            vv.AddVideo(v7);
            vv.AddVideo(v8);
            vv.AddVideo(v9);

            v.PrintVideoDetails();

            vv.PrintAllVideoPlaycount();
        }
    }
}
