using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static char[] operation = new char[] { '+', '-' };
        static void findCombinations(string expression, List<char> symbList, int lvl)
        {
            if (lvl < symbList.Count)
            {
                findCombinations(expression.Replace(symbList[lvl], operation[0]), symbList, lvl + 1);
                findCombinations(expression.Replace(symbList[lvl], operation[1]), symbList, lvl + 1);
                findCombinations(expression.Remove(expression.IndexOf(symbList[lvl]), 1), symbList, lvl + 1);
            }
            else
            {
                DataTable dt = new DataTable();
                int value = (int)dt.Compute(expression, "");
                if (value == 100)
                {
                    Console.WriteLine(expression);
                }
            }
        }
        public static void Main(string[] args)
        {
            string strExpression = "1a2b3c4d5e6f7g8h9";
            List<char> symbList = new List<char>();
            for (int i = 0; i < 8; i++)
            {
                symbList.Add((char)('a' + i));
            }
            findCombinations(strExpression, symbList, 0);
        }
    }
}
