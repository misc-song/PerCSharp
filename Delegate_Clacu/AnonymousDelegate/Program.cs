using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str1 = "字符串1,";
            //Func<string, string> str_full = delegate(string str0)//此处并没有将一个方法传递给Func<T> 而是使用了delegate关键字其后面是一个字符串参数
            //{
            //    str0 += str1;
            //    str0 += "字符串2,";
            //    return str0;
            //};
            //Console.WriteLine(str_full("字符串0,"));

            string str1 = "字符串1,";
            Func<string, string> str_full = str0 =>
            {
                str0 += str1;
                str0 += "字符串2,";
                return str0;
            };
            Console.WriteLine(str_full("字符串0,"));
        }
    }
}
//Func<string,string> bnoy = str1 =>
//           {
//               str1 += mid;
//               str1 += "and XXX!";
//               return str1;
//           };
//Console.WriteLine(bnoy("aaaa"));