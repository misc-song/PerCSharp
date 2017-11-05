using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //public delegate double Get_Result(double num); //声明一个委托类
    public class Math_Method//测试委托类
    {
        public static double Method1(double number)//测试方法一:接受一个值 返回这个值的2倍
        {
            return number * 2;
        }
        public static double Method2(double number)//测试方法二:接受一个值 返回这个值的平方
        {
            return number * number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*操作委托类型的数组和普通的数组是一样的*/
            //Get_Result[] gr = new Get_Result[] //实例化委托数组
            //{
            //    Math_Method.Method1,
            //    Math_Method.Method2
            //};
            //将上面的方法用Func<T>进行改写
            Func<double, double>[] gr = 
            {
                  Math_Method.Method1,
                  Math_Method.Method2
            };

            // Console.WriteLine(gr[0](12));//执行委托(方法一对应的是输出2倍)并打印结果
            // Console.WriteLine(gr[1](12));//执行委托(方法二对应的是输出平方)并打印结果
            for (int i = 0; i < gr.Length; i++)//使用for循环来代替上面的语句
            {
                Console.WriteLine(gr[i](12));
            }

        }
    }
}
