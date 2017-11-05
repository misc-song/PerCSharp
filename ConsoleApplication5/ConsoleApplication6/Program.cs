using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入文件名");
            string str = Console.ReadLine();
            File f = ShowFile(Path.GetFileNameWithoutExtension(str), Path.GetExtension(str).ToLower());
            f.ShowFile();
        }

        public static File ShowFile(string fname, string ename)
        {
            File f = null;
            switch (ename)
            {
                case ".txt": f = new TXTFile(fname, ename); break;
                case ".html": f = new HTMLFIle(fname, ename); break;
                case ".avi": f = new AVIFile(fname, ename); break;
            }
            return f;
        }
    }
}
