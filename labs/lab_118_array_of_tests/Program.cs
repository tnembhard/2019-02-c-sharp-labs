using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace lab_118_array_of_tests
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }

    public class FileOperationSynchronous
    {
        public long FileReadWrite(int NumberOffFiles)
        {
            string data = "Saving some data - ";
            // create a stopwatch
            var s = new Stopwatch();
            s.Start();

            // write NumberOffFiles times to a file synchronously
            for (int i = 0; i < NumberOffFiles; i++)
            {
                File.WriteAllText("data.txt", data + 1);
            }

            // read 100 times to that same file
            for (int i = 0; i < 1000; i++)
            {
                File.ReadAllText("data.txt");
            }

            // end stopwatch
            s.Stop();
            string output = $"Total time 1000 files write then read is {s.ElapsedMilliseconds}";

            // upgrade to this : create 1000 files!
            // string filename = "data" + string.format(1,D3 + ".txt";
            // data000.txt - data999.txt

            return s.ElapsedMilliseconds;
        }

        public long TaskArrayFileReadWrite(int NumberofFiles)
        {
            // one task )(input) => { method body }
            var singleTask = Task.Run(() => { });


            Task.WaitAll(singleTask);

            var s = new Stopwatch();
            s.Start();

            // array of tasks
            Task[] tasks = new Task[NumberofFiles];

            for (int i = 0; i < NumberofFiles; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    // write to file

                    // read from file

                });
            }

            Task.WaitAll(tasks);
            s.Stop();

            return s.ElapsedMilliseconds;

            // Homework 1) complete and test read/write 1000 then 10000 files as task
            //          2) Bonus : Create new project, add Northwind, update contact
            //                      name of 1 customer 1000 times using 1000 tasks.
        }
    }
}
