using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //House h = new House();
            //h.Reg();
            //Person p = new Person();
            //p.Reg();
            //Car c = new Car();
            //c.Reg();
            //Student s = new Student();
            //s.Reg();




            //IRegister ir = GetRegster(new Car());
            //ir.Reg();
            GetRegster(new Car());





        }
        public static void GetRegster(IRegister ir)
        {
            //if(ir is Car)
            //{
            //    ir = new Car();
            //}
            //else if(ir is House)
            //{
            //    ir = new Car();
            //}
            //else if(ir is Person)
            //{
            //    ir = new Car();
            //}
            ir.Reg();
        }
    }
}
