using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_116_Try_Catch_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 0;
            try
            {
                try
                {
                    int z = x / y;
                    throw new Exception("This is a seious error!");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine(e.Data);
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine(e.Data);
                    Console.WriteLine(e.Message);
                    throw;
                }
                finally { }

            }
            catch (Exception e)
            {
                Console.WriteLine("Thrown Exception caught");                
            }
            finally 
            {
                Console.WriteLine("All done");
            }
        }
    }
}
