using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public class MyClass
    {
        string name;
        string place;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass c;
            MyClass v;
            c = new MyClass();
            v = new MyClass();
            if (ReferenceEquals(c, v))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
