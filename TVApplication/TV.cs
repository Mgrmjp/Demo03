using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApplication
{
    class TV
    {
        public bool IsOn { get; set; }
        public int Channel { get; set; }
        public int Brightness { get; set; }
        public int Volume { get; set; }
        

        public void NextChannel()
        {
            Channel += 1;
        }
        public void LowerVolume()
        {
            Volume -= 5;
        }
        public void TurnUpVolume()
        {
            Volume += 5;
        }
        public void LowerBrightness()
        {
            Brightness -= 15;
        }
        public void RaiseBrightness()
        {
            Brightness += 15;
        }
        public void CurrentSettings()
        {
            Console.WriteLine();
            Console.WriteLine("Television - - - - - // ");
            Console.WriteLine("Channel // " + Channel);
            Console.WriteLine("Volume // " + Volume);
            Console.WriteLine("Brightness // " + Brightness);
            Console.WriteLine();
        }
    }
}
