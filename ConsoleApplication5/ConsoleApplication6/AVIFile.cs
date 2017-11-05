using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class AVIFile : File
    {
        public AVIFile(string fname, string ename)
            : base(fname, ename)
        { }
        public override void ShowFile()
        {
            Console.WriteLine("因为文件后缀名是{0},所以这是一个视频文件,可以用快播打开",this.extensionName);
        }
    }
}
