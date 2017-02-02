using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Name = "Tuhnu";
            vehicle.Speed = 500;
            vehicle.Tyres = 6;

            vehicle.PrintData();

            Console.WriteLine(vehicle);
            Console.WriteLine();

            vehicle.Name = "Tuhnumpi";
            vehicle.Speed = 600;
            vehicle.Tyres = 8;

            vehicle.PrintData();

            Console.WriteLine(vehicle);
            Console.WriteLine();


        }
    }
}
