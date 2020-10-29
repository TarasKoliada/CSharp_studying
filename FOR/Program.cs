using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int limit = int.Parse(Console.ReadLine()); 
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(i);
            }*/
            int i = 0;
            for (; i < 3; i++)
            {
                Console.WriteLine("For_1: "+i);
            }
            for (;  i< 5; i++)
            {
                Console.WriteLine("For_2: "+i);
            }
        }
    }
}
