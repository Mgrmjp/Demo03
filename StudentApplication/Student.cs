using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    public class Student
    {
        // Variables

                public string name;
                public int age;
                public string phone;
                public string address;
                public int studentID;

                public string Name
                {
                    get { return name; }
                    set { name = value; }
                }

                public int Age
                {
                    get { return age; }
                    set { age = value; }
                }

                public string Phone
                {
                    get { return phone; }
                    set { phone = value; }
                }

                public string Address
                {
                    get { return address; }
                    set { address = value; }
                }

                public int StudentID
                {
                    get { return studentID; }
                    set { studentID = value; }
                }

        // Methods

                public void GoToSchool()
                {
                    Console.WriteLine("I love waking up in the morning, it's the best!");
                }

                public void SkipSchool()
                {
                    Console.WriteLine("Skipping school? Nonsense.");
                }

                public void GoHome()
                {
                    Console.WriteLine("Wish I could stay at school 24/7.");
                }

                public void Eat()
                {
                    Console.WriteLine("What a wonderful meal for 2,60!");
                }

                public void DrinkCoffee()
                {
                    Console.WriteLine("It just doesn't get any better than this.");
                }
    }
}
