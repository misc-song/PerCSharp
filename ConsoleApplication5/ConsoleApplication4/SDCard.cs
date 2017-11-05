using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class SDCard:MobileStorageDivece
    {
        public override void Read()
        {
            Console.WriteLine("SD卡正在读取中...");
        }

        public override void Write()
        {
            Console.WriteLine("SD卡正在写入中...");
        }
    }
}
