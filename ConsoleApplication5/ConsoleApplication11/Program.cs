using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "xml.xml";
            XDocument xt = XDocument.Load(path);
            XElement xe = xt.Root;
            IEnumerable<XElement> xel = xe.Elements();
            foreach (XElement i in xel)
            {

                foreach (XElement j in i.Elements())
                {
                    Console.WriteLine(j.Attribute("id").Value);
                    Console.WriteLine(j.Element("name").Value);
                    Console.WriteLine(j.Element("gender").Value);
                }
            }

        }
    }
}
