using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {

        static List<UInt64> FindFib(int fibCnt)
        {
            if (fibCnt < 0) return null;
            List<UInt64> numbersLst = new List<UInt64>(fibCnt + 1);
            numbersLst.Add(0);
            numbersLst.Add(1);
            int cnt = 2;
            while (cnt < fibCnt)
            {
                numbersLst.Add(numbersLst[cnt - 1] + numbersLst[cnt - 2]);
                ++cnt;
            }
            return numbersLst;
        }
        public static void Main(string[] args)
        {
            List<UInt64> fibList = FindFib(100);

            foreach (var num in fibList)
            {
                Console.Write($"{num} ");
            }
           
        }
    }
}
