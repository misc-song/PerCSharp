using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            //int num = 1;
            //在C#语言中没有使用break是会报错的(注释此处代码)
            //switch (num)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("输出的是1");
            //        }
            //    case 2:
            //        {
            //            Console.WriteLine("输出的是2");
            //        }
            //    case 3:
            //        {
            //            Console.WriteLine("输出的是3");
            //        }
            //    case 4:
            //        {
            //            Console.WriteLine("输出的是4");
            //        }
            //    case 5:
            //        {
            //            Console.WriteLine("输出的是5");
            //        }
            //    default:
            //        {
            //            Console.WriteLine("没有指定的结果");
            //        }

            //}

            int number = 1;
            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("输出的是1");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("输出的是2");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("输出的是3");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("输出的是4");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("输出的是5");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("没有指定的结果");
                        break;
                    }

            }
        }
    }
}
