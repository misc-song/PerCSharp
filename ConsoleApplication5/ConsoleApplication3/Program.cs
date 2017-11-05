using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Test
    {
        //public string? tes { get; set; }
        public string @Name { get; set; }
        public int A()
        {
            try { return 1; }
            catch { return 2; }
            finally { return 3; }
            return 4;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            //t.tes = 'd';
            //Console.WriteLine(t.tes);
            //object obj = 5;
            //int a = obj;
            //int b = (int)obj;
            //int c = obj as int;
            t.A();
        }
    }
}
