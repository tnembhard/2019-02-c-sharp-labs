using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_16_NUnit_XUNIT_Tests
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
    public class TestMeNow
    {
        public double TestThisMethodWokrs(double x, double y, int p)
        {
            // 2,3,3 ==> (2*3)-6 and raise this to the power
            Console.WriteLine($"Here is some data{x},{y},{p}");
            return Math.Pow((x*y),p);
        }
    }
}
