using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_07_files
{
    class Program
    {
        static void Main(string[] args)
        {
            //try - code that can possibly crash
            try
            {
                // file read as string

                string data01 = File.ReadAllText("file.txt");
            }
            //specific : Handling the exception
            catch (FileNotFoundException ex)
            {

                Console.WriteLine("Make that file");
            }
            //always run regardless
            finally
            {
                Console.WriteLine("make it quick");
            }

        }
    }
}
