using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    public delegate void GetString();//创建委托
    public class Funcs
    {
        public static void Fun1()//创建静态方法
        {
            Console.WriteLine("这是Fun1");

        }
        public static void Fun2()
        {
            Console.WriteLine("这是Fun2");

        }
        public static void Fun3()
        {
            Console.WriteLine("这是Fun3");

        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            GetString FirstFunc = new GetString(Funcs.Fun1);//实例化委托
            GetString SecondFunc = new GetString(Funcs.Fun2);
            GetString ThirdFunc = new GetString(Funcs.Fun3);
            FirstFunc += SecondFunc;//多播委托
            FirstFunc += ThirdFunc;
            FirstFunc.Invoke();//执行委托
        }

    }
}
