using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //public class Test
    //{
    //    public int tr { get; set; }
    //}
    public class BubbleSort
    {
        public static void funtion(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("排序过后的结果是:");
            foreach (int num in arr)
            {
                Console.Write(num);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //dynamic ct = new Test();
            //ct.tr = 11;
            //Console.WriteLine(ct.tr);
            int[] num = { 1, 9, 7, 5, 2, 3, 4 };
            BubbleSort.funtion(num);
        }
    }
}
