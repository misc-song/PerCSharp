using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class TXTFile : File
    {
        public TXTFile(string fname, string ename)
            : base(fname, ename)
        { }

        public override void ShowFile()
        {
            Console.WriteLine("因为文件的后缀名是{0},所以这是一个文本文件,可以通过记事本打开", this.extensionName);
        }
    }
}
