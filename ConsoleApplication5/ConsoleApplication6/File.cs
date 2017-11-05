using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public abstract class File
    {
        public File(string fname, string ename)
        {
            this.fileName = fname;
            this.extensionName = ename;
        }
        public string fileName { get; set; }
        public string extensionName { get; set; }
        public abstract void ShowFile();

    }
}
