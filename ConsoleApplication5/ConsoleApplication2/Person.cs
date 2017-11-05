using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Person : IRegister
    {
        public void Reg()
        {
            Console.WriteLine("人被登记了");
        }
    }
}
