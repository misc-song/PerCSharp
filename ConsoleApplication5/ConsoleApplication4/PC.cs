using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class PC
    {
        public MobileStorageDivece msd { get; set; }
        public void CompurterRead()
        {
            msd.Read();
        }
        public void CompurterWrite()
        {
            msd.Write();
        }
    }
}
