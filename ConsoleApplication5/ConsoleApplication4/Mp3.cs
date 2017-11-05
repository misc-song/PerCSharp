using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Mp3:MobileStorageDivece
    {
        public override void Read()
        {
            Console.WriteLine("Mp3正在读取中...");
        }

        public override void Write()
        {
            Console.WriteLine("Mp3正在写入中...");
        }
        public void PlayMusic()
        {
            Console.WriteLine("Mp3正在播放音乐...");
        }
    }
}
