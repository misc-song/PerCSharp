using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            double number1 = 1;
            double number2 = 2;
            Func<double, double> res = pram =>//一个参数的lambda表达式
                {
                    pram += number1;
                    pram += number2;
                    return pram;
                };
            Console.WriteLine("number1+number2+pram的结果是:{0}", res(3));

            //当lambda表达式只有一行语句的时候可以省略Return语句 其中隐式包含了return 
            int xy = 5;
            Func<int, int> f = x => xy + x;
            Console.WriteLine(f(3));

            Func<double, double, double> resul = (x, y) => x += y;//两个参数的lambda表达式
            Console.WriteLine("x+y的结果是:{0}", resul(1, 2));

            //但是花括号中包含了多条语句的时候就需要return语句了(此时的return语句不可被省略)
            Func<double, double, double> resu = (x, y) =>//两个in参数 一个out结果
                {
                    x += y;
                    return x;
                };
            Console.WriteLine("x+y的结果是:{0}", resu(1, 2));
        }
    }
}
//string mid = "中间,";
//Func<string, string> fc = delegate(string str)
//{
//    str += mid;
//    str += "后面.";
//    return str;
//};
//Console.WriteLine(fc("前面,"));
//double number1 = 1;
//double number2 = 2;
//Func<double, double> res = pram =>//一个参数的lambda表达式
//    {
//        pram += number1;
//        pram += number2;
//        return pram;
//    };
//Console.WriteLine("number1+number2+pram的结果是:{0}", res(3));
//public class Client
//{
//    public static string Method1()
//    {
//        return "这是方法一";
//    }
//}