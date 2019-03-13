using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace lab_121_hash_set_to_excel
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class HashSetToExcel
    {
        int[] nums = new int[3];
        HashSet<int> Hash = new HashSet<int>();
        LinkedList<int> Linked = new LinkedList<int>();
        Dictionary<int, int> Dict = new Dictionary<int, int>();
        Stopwatch s = new Stopwatch();
        public Custom HashSetToExcelTest(int a, int b, int c)
        {
            s.Start();
            nums[0] = a;
            nums[1] = b;
            nums[2] = c;
            for (int i = 0; i < nums.Length; i++)
            {
                Hash.Add(nums[i] * 2);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Linked.AddLast(nums[i] * 2);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Dict.Add(i,nums[i] + 15);
            }
            s.Stop();

            return new Custom (Dict[0], Dict[1], Dict[2], s.ElapsedMilliseconds);
        }
    }

    public class Custom
    {
        private int firstNumber;
        private int secondNumber;
        private int thirdNumber;
        private long time;

        public int FirstNumber { get => firstNumber; set => firstNumber = value; }
        public int SecondNumber { get => secondNumber; set => secondNumber = value; }
        public int ThirdNumber { get => thirdNumber; set => thirdNumber = value; }
        public long Time { get => time; set => time = value; }

        public Custom(int firstNum, int secondNum, int thirdNum, long eTime)
        {
            FirstNumber = firstNum;
            SecondNumber = secondNum;
            ThirdNumber = thirdNum;
            Time = eTime;
        }
    }
}
