using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    interface Istack
    {
        void fly();
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "123-456----789-----147----852------------963";
            string[] array = str.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            string newstr = string.Join("-", array);
            Console.WriteLine("原先的字符串是{0}\n,转码后的结果是{1}", str, newstr);
        }
    }
}
