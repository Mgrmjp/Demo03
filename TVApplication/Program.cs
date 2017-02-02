using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            tv.IsOn = true;
            tv.Channel = 0;
            tv.Volume = 25;
            tv.Brightness = 100;
            

            tv.NextChannel();
            Console.WriteLine("The channel is now ~ " + tv.Channel);
            tv.NextChannel();
            Console.WriteLine("The channel is now ~ " + tv.Channel);

            tv.TurnUpVolume();
            Console.WriteLine("Volume / " + tv.Volume);

            tv.LowerVolume();
            Console.WriteLine("Volume / " + tv.Volume);

            tv.RaiseBrightness();
            Console.WriteLine("Brightness raised to " + tv.Brightness);

            tv.LowerBrightness();
            Console.WriteLine("Brightness lowered to " + tv.Brightness);

            Console.WriteLine("\n - TV info - ");
            tv.CurrentSettings();
        }
    }
}
