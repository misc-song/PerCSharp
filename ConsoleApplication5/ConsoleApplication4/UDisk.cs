using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class UDisk:MobileStorageDivece
    {
        public override void Read()
        {
            Console.WriteLine("U盘正在读取中.....");
        }

        public override void Write()
        {
            Console.WriteLine("U盘正在写入中.....");
        }
    }
}
