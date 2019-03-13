using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_25_checked_unchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            int x = int.MaxValue;
            Console.WriteLine(++x);
            int y = 400000000;
            int z = y * 10;
            Console.WriteLine(z);

            // INTEGERS ARE NOT CHECKED FOR OVERFLOW BECAUSE ITS CPU INTENSIVE

            // EXPLICITLY CHECK FOR OVERFLOW WITH CHECK KEYWORD
            checked
            {
                unchecked
                {
                    int b = int.MaxValue;
                    Console.WriteLine(++b);
                }
                int a = int.MaxValue;
                //Console.WriteLine(++a);
            }
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(double.MaxValue);
        }
    }
}