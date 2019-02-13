using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Parent("Bill",22);
            var p02 = new Parent("Bill");
            var p03 = new Parent(age: 22, name: "Bill"); // named parameters
            p01.Name = "Bill";            
        }
    }
    class Parent
    {
        private int _dob; // private field, lower case, _start
        public string Name { get; set; } // public property
        public int Age { get; set; }
        public Parent() { }
        public Parent(string name)
        {
            this.Name = name;
        }
        public Parent(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

    }
    class LoopT
    {

        public int testLoop(int test)
        {
            //create a loop that takes in 10 and returns 145 

            int total = 0;
            for (int i = 0; i < test; i++)
            {
                total += i + test;
            }

            return total;
        }
    }

}
