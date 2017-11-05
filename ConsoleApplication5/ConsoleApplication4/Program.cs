using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            PC p = new PC();
            //p.msd = new Mp3();
            //p.CompurterRead();
            //p.CompurterWrite();
            GetDevice(new Mp3());
            GetDevice(new SDCard());
            GetDevice(new UDisk());
        }

        private static void GetDevice(MobileStorageDivece msd)
        {

           if(msd is Mp3)
           {
               Mp3 mp3 = msd as Mp3;
               mp3.Read();
               mp3.Write();
               mp3.PlayMusic();
           }
           if (msd is SDCard)
           {
               SDCard sd = msd as SDCard;
               sd.Read();
               sd.Write();
           }
           if (msd is UDisk)
           {
               UDisk u = msd as UDisk;
               u.Read();
               u.Write();
           }
        }
    }
}
