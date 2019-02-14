using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_104_array_list_queue_stack_dict_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Put 10 numbers in to array
            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Move every the items to a list and add 1 (interger)
            List<int> myList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                myList.Add(myArray[i] + 1);
            }
            // Move to stack and add 1
            Stack<int> myStack = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                myStack.Push(myList[i] + 1);
            }
            // Move to a queue and add 1
            Queue<int> myQueue = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                myQueue.Enqueue(myStack.Pop() + 1);
            }
            // to dictionary and add 1
            Dictionary<int,int> myDict = new Dictionary<int,int>();
            for (int i = 0; i < 10; i++)
            {
                myDict.Add(i, myQueue.Dequeue() + 1);
            }
            // Return total
            int sum = 0;
            foreach(int key in myDict.Keys)
            {
                sum += myDict[key];
            }
            Console.WriteLine(sum);
        }        
    }
}
