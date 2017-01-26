using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherApplication
{
    class Washer
    {
        public bool IsRunning { get; set; }
        public int RunTime { get; set; }
        public int Temperature { get; set; }

        public void Wash()
        {
            Console.WriteLine("\nJag är washing the vaatteet.\n");
        }

        public void Sling()
        {
            Console.WriteLine("Jag är slinging the vaatteet.\n");
        }


    }
}
