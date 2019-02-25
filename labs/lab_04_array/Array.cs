using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04_array
{
    public class Array
    {
        // build some code here : test output
        public int CreateArray(int size)
        {
            int[] myArray = new int[size];
            // insert squares
            for (int i=0; i < size; i++ )
            {
                myArray[i] = i * i;
                Console.WriteLine(myArray[i]);
            }

            // check values
            int total = 0;
            foreach (int i in myArray)
            {
                total += i;
                Console.WriteLine(i);
            }
            return total;
        }

    }
}
