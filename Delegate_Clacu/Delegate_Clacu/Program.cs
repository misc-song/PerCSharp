using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Calcu
{
    public delegate string Math_Opertion(double num1, double num2);//声明一个委托类
    public class Calculator
    {
        public static string Calculate_Add(double op1, double op2)//加
        {
            return "两个数相加的结果:" + (op1 + op2);
        }
        public static string Calculate_Subtract(double op1, double op2)//减
        {
            return "两个数相减的结果:" + (op1 - op2);
        }
        public static string Calculate_Multiply(double op1, double op2)//乘
        {
            return "两个数相乘的结果:" + (op1 * op2);
        }
        public static string Calculate_Divide(double op1, double op2)//除
        {
            return "两个数相除的结果:" + (op1 / op2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Math_Opertion[] mo = new Math_Opertion[]//实例化委托数组 
            {
                Calculator.Calculate_Add,
                Calculator.Calculate_Subtract,
                Calculator.Calculate_Multiply,
                Calculator.Calculate_Divide
            };
            Console.WriteLine("请输入需要计算的第一个数:");
            double num1 = double.Parse(Console.ReadLine());//输入第一个数
            Console.WriteLine("请输入需要计算的第二个数:");
            double num2 = double.Parse(Console.ReadLine());//输入第二个数
            for (int i = 0; i < mo.Length; i++)
            {
                Console.WriteLine(mo[i](num1, num2));//循环遍历结果
            }
        }
    }
}
