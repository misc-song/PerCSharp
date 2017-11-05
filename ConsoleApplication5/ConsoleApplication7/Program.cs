using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class Program
    {
        static void Main()
        {

            string str = "我爱你";
            char[] temp = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char tmp = temp[i];
                temp[i] = temp[j];
                temp[j] = tmp;
            }
            str = string.Join("", temp);
            Console.WriteLine(str);


        }
    }
}
