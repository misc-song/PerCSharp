using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Car : IRegister
    {
        public void Reg()
        {
            Console.WriteLine("车子被登记了");
        }
    }
}
