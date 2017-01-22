using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序
{
    public class PopQueue
    {
        public static void Pop1(int[] ls)
        {
            for (int i = 0; i < ls.Length - 1; i++)
            {
                for (int j = 0; j < ls.Length - 1 - i; j++)
                {
                    if (ls[j] > ls[j + 1])
                    {
                        int temp = ls[j];
                        ls[j] = ls[j + 1];
                        ls[j + 1] = temp;
                    }
                }
            }
            Console.Write("排序的结果是:");
            foreach (int res in ls)
            {
                Console.Write(res);
            }
        }
        public static void Pop2(List<int> ls)
        {
            for (int i = 0; i < ls.Count - 1; i++)
            {
                for (int j = 0; j < ls.Count - 1 - i; j++)
                {
                    if (ls[j] > ls[j + 1])
                    {
                        int temp = ls[j];
                        ls[j] = ls[j + 1];
                        ls[j + 1] = temp;
                    }
                }
            }
            Console.Write("排序的结果是:");
            foreach (int res in ls)
            {
                Console.Write(res);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] ls = new int[] { 6, 4, 7, 8, 9, 4, 2, 0 };
            PopQueue.Pop1(ls);
            Console.WriteLine();
            List<int> ls1 = new List<int> { 6, 4, 7, 8, 9, 4, 2, 0 };
            PopQueue.Pop2(ls1);
            Console.WriteLine();
        }
    }
}
