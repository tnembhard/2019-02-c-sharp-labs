using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab_113_Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Arraylist
    {
        public int arraylistmethod(int a, int b, int c, int d)
        {
            //accept 4 integers
            //put to array
            //extract ==> double ==> put to a queue
            //extract ==> double ==> put to a stack
            //extract ==> double ==> put to a dictionary
            //put to arraylist
            //extract and get the sum of the items and return this sum
            var arr = new int[] { a, b, c, d };
            var que = new Queue<int>();
            var stac = new Stack<int>();
            var dict = new Dictionary<int, int>();
            var arraylist = new ArrayList();
            
            for (int i = 0; i < arr.Length; i++)
            {
                que.Enqueue(arr[i]*2);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                stac.Push(que.Dequeue()*2);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                
                dict.Add(i, stac.Pop() * 2);
            }
            foreach (var item in dict)
            {
                arraylist.Add(item.Value);
            }

            int total = 0;
            foreach (var item in arraylist)
            {
                total += (int)item;
            }

            return total;

        }
    }
}
