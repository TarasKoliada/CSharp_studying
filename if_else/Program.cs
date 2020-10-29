using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a;
            a = int.Parse(Console.ReadLine());


            if (a % 2 == 0)
            {
                Console.WriteLine("Num is honest for 2");
            }
            else if (a % 3 == 0)
            {
                Console.WriteLine("Num is honest for 3");
            }
            else 
            {
                Console.WriteLine("num is odd");
            }
           
        }
    }
}
