using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static int GetSumUsingFor(List<int> list)
        {
            int sum = 0;
            foreach (int num in list)
            {
                sum += num;
            }
            return sum;
        }
        static int GetSumUsingWhile(List<int> list)
        {
            int sum = 0;
            int i = 0;
            while (i < list.Count)
            {
                sum += list[i++];
            }
            return sum;
        }
        static int GetSumUsingRec(List<int> list, int ind = 0)
        {
            if(ind >= list.Count)
            {
                return 0;
            }
            return list[ind] + GetSumUsingRec(list, ind + 1);
        }

        public static void Main(string[] args)
        {
            List<int> numList = new List<int> { 1, 2, 3, 4, 1, 2, 3, 9, -10, 5, 4 };
            Console.WriteLine("Using for-loop:{0}\nUsing while:{1}\nUsing recursion:{2}",
                    GetSumUsingFor(numList), GetSumUsingWhile(numList), GetSumUsingRec(numList));

        }
    }
}
