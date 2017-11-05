using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public delegate void Delegate_Class1(string str);//声明一个委托带参没有返回值的委托
    public delegate int Delegate_Class2(int num1, int num2);//声明一个带两个参数且有返回值(int)的委托
    public class Delegate_Test//委托测试类
    {
        public static void PrintName(string str)//一个简单的控制台打印字符串的方法
        {
            Console.WriteLine(str);
        }
        public static int ReturnNum(int op1, int op2)//一个简单的返回结果的方法
        {
            return op1 + op2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Delegate_Class1 tr = Delegate_Test.PrintName;//使用委托:写法一直接将方法名给实例化的委托实例
            tr("小明");//执行委托写法一:直接用实例化的委托变量
            tr.Invoke("小明");//执行委托写法二:使用实例化的委托变量的Invoke()方法 
            /*其中tr是委托类型的变量所以在实际执行时C#编译器会用tr.Invoke()来代替tr()*/
            Delegate_Class1 tr1 = new Delegate_Class1(Delegate_Test.PrintName);//使用委托:写法二使用委托的构造函数
            tr1("小华");

            Delegate_Class2 it = new Delegate_Class2(Delegate_Test.ReturnNum);
            int temp = 0;//声明一个临时变量用于保存委托返回的结果
            temp = it(2, 4);//执行委托
            Console.WriteLine(temp);//打印结果

        }

    }
}
