using System;

namespace lab_31_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            var P01 = new Point(10, 10);
            var P02 = new Point(20, 20);
        }
    }

    class X { }
    struct Point
    {
        public int x;
        public int y;
        //CONSTRUCTOR
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
