using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_23_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // latast way of running task

            Task.Run(() =>
            {
                Console.WriteLine("Running a background task 1");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Finishing task 1");
            });

            Task.Run(() =>
            {
                Console.WriteLine("Running a background task 2");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Finishing task 2");
            });

            Task.Run(() =>
            {
                Console.WriteLine("Running a background task 3");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Finishing task 3");
            });

            //for (int i = 0; i < 100; i++)
            //{
            //    Task.Run(() =>
            //    {
            //        Console.WriteLine($"Running a background task {i}");
            //        System.Threading.Thread.Sleep(5000);
            //        Console.WriteLine($"Finishing task {i}");
            //    });
            //}

            Console.WriteLine("all done");

            Console.ReadLine();

            // most recent

            var task01 = new Task(() =>
            {                
                Console.WriteLine("Task01 (new Task) is running");
            });
            task01.Start();

            //slightly older

            var task02 = Task.Factory.StartNew(() =>
            {
               Console.WriteLine("task 02 (Factory.Start) is running");
            });

            // passing in a delegate
            // Action delegate whoch DOES AN ACTION (DOES SOMETHING) BUT RETURNS VOID

            var task03 = new Task(new Action(ActionMethod));
            task03.Start();

            // repeat but add in a proper declared action variable

            var ActionMethod02 = new Action(ActionMethod);
            // or (quicker)
            Action ActionMethod03 = ActionMethod;

            var task04 = new Task(ActionMethod03);
            task04.Start();

        }
        static void ActionMethod()
        {
            Console.WriteLine("Task 03 (ActionMethod) is running");
        }
    }

}
