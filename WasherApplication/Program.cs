using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Washer washer = new Washer();
            washer.IsRunning = true;
            washer.Temperature = 45;
            washer.RunTime = 60;
            int mode = 0;

            Console.WriteLine("Water temperature is " + washer.Temperature);
            Console.WriteLine("The washer will run for " + washer.RunTime);
            mode++;

            if (mode == 1) washer.Wash();

            else if (mode == 0) washer.Sling();


        }
    }
}
