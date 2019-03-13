#define GOD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_17_debug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starting app");
#if DEBUG
            Console.WriteLine("This is debug code");
#endif

#if GOD
            Console.WriteLine("Jesus Walks!");
            Console.WriteLine("God show me the way, because the devil is trying to break me down");
#endif
            Console.WriteLine("Finishing app");
        }
    }
}
