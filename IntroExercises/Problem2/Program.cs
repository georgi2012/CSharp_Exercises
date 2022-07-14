using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static List<object> CombineLists(List<object> firstList, List<object> secondList)
        {
            List<object> combinedList = new List<object>(firstList.Count + secondList.Count);
            int indLst1 = 0, indLst2 = 0;
            while (indLst1 < firstList.Count && indLst2 < secondList.Count)
            {
                combinedList.Add(firstList[indLst1++]);
                combinedList.Add(secondList[indLst2++]);
            }
            while (indLst1 < firstList.Count)
            {
                combinedList.Add(firstList[indLst1++]);
            }
            while (indLst2 < secondList.Count)
            {
                combinedList.Add(secondList[indLst2++]);
            }
            return combinedList;
        }

        public static void Main(string[] args)
        {
            List<char> firstLst = new List<char> { 'a', 'b', 'c' };
            List<int> secondLst = new List<int> { 1, 2, 3, 4, 5 };
            List<object> objlist = CombineLists(firstLst.Cast<object>().ToList(),
                secondLst.Cast<object>().ToList());

            foreach(var obj in objlist)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();
        }
    }
}
