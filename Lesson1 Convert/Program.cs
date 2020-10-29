using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "4";
            string b = "3";
            int i = Convert.ToInt32(a);
            int c = Convert.ToInt32(b);
            Console.WriteLine(i+c);
            //Convert.ToInt32(Console.WriteLine(a + b));
        }
    }
}
