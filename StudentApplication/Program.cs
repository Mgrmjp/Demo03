using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            // Init array and set values
            Student[] pleb = new Student[5];

            pleb[0] = new Student();
            pleb[0].Name = "Matt Johnson";
            pleb[0].Age = 18;
            pleb[0].Phone = "342-644-7843";
            pleb[0].Address = "Somewhere Old";
            pleb[0].StudentID = 1111;

            pleb[1] = new Student();
            pleb[1].Name = "John Mattson";
            pleb[1].Age = 19;
            pleb[1].Phone = "653-222-945";
            pleb[1].Address = "Somewhere New";
            pleb[1].StudentID = 2222;

            pleb[2] = new Student();
            pleb[2].Name = "Jonas Lindholm";
            pleb[2].Age = 21;
            pleb[2].Phone = "632-753-0987";
            pleb[2].Address = "Somewhere Else";
            pleb[2].StudentID = 3333;

            pleb[3] = new Student();
            pleb[3].Name = "Martin Karlsson";
            pleb[3].Age = 25;
            pleb[3].Phone = "453-678-5453";
            pleb[3].Address = "Murica";
            pleb[3].StudentID = 4444;

            pleb[4] = new Student();
            pleb[4].Name = "Kari Niemi";
            pleb[4].Age = 65;
            pleb[4].Phone = "456-223-3333";
            pleb[4].Address = "Piippukatu 2";
            pleb[4].StudentID = 1337;


            // Print out student info
            Console.WriteLine("-*- Student Information -*-\n");

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Name // " + pleb[i].Name);
                Console.WriteLine("Age // " + pleb[i].Age);
                Console.WriteLine("Phone // " + pleb[i].Phone);
                Console.WriteLine("Address // " + pleb[i].Address);
                Console.WriteLine("StudentID // " + pleb[i].StudentID);
                Console.WriteLine();
            }

            
        }
    }
}
