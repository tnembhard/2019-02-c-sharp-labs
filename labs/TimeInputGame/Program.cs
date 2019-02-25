using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeInputGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool choice = false;
            Console.WriteLine("Please choose between playing the simple (unsorted) or strict (sorted) mode: ");
            string mode = Console.ReadLine();

            while (choice == false)
            {            
                if (mode == "simple")
                {
                    Typing_Challenge.First_Mode();
                    choice = true;
                }
                else if (mode == "strict")
                {
                    Typing_Challenge.Secondo_Mode();
                    choice = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter either 'simple' or 'strict'.");
                }
            }
        }
    }
    class Typing_Challenge
    {        
        public static void First_Mode ()
        {
            List<char> input = new List<char>();
            int count = 0;
            int userTime = 0;
            Console.WriteLine("Input the how long you want game to run for in seconds: ");
            userTime = Convert.ToInt32(Console.ReadLine());
            var time = DateTime.Now;

            do
            {
                input.Add(Console.ReadKey().KeyChar);                
            } while (DateTime.Now - time < TimeSpan.FromSeconds(userTime));

            Console.WriteLine(" ");
            Console.WriteLine("Time is up!");
            Console.WriteLine(" ");
            Console.Write(" You inputted the following keys: ' ");
            for (int j = 0; j < input.Count; j++)
            {
                Console.Write(input[j]);
                count = j;
            }
            Console.Write(" ' ");
            Console.WriteLine(" You entered a total of: "+count+" characters.");
        }

        public static void Secondo_Mode()
        {
            List<char> input = new List<char>();
            List<char> check = new List<char>();
            char[] az = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            check.AddRange(az);
            int count = 0;
            int userTime = 0;
            char verify = '0';
            int k = 0;
            Console.WriteLine("Input the how long you want game to run for in seconds: ");
            userTime = Convert.ToInt32(Console.ReadLine());
            var time = DateTime.Now;

            do
            {
                verify = Console.ReadKey().KeyChar;
                if (verify == check[k])
                {
                    input.Add(verify);
                    k++;
                }
                else
                { 
                    Console.WriteLine("Invalid input"); 
                }

            } while (DateTime.Now - time < TimeSpan.FromSeconds(userTime));

            Console.WriteLine(" ");
            Console.WriteLine("Time is up!");
            Console.WriteLine(" ");
            Console.Write(" You inputted the following keys: ' ");
            for (int j = 0; j < input.Count; j++)
            {
                Console.Write(input[j]);
                count = j;
            }
            Console.Write(" ' ");
            Console.WriteLine(" You entered a total of: " + count + " characters.");
        }
    }
}
