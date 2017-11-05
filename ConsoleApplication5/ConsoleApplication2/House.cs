using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class House : IRegister
    {
        public void Reg()
        {
            Console.WriteLine("房子被登记了");
        }
    }
}
