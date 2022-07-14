using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static int GetFirstDigit(int num)
        {
            int digits = (int)Math.Log10(num);
            return (int)(num / Math.Pow(10, digits));
        }

        static void PrintBiggestNumber(List<int> numList)
        {
            var orderedByGreatestFirst = numList.OrderByDescending(x => GetFirstDigit(x));
            foreach(var num in orderedByGreatestFirst)
            {
                Console.Write(num);
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            List<int> numList = new List<int> { 1, 90, 100, 20, 5, 6 };
            PrintBiggestNumber(numList);
        }

    }
}
