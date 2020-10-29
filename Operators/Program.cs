using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert.ToInt32
           // int a = Console.ReadLine();
           // int b;
            Console.WriteLine("Enter first numeric: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second numeric");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = (a + b) / 2;
            Console.WriteLine("Arithmetic mean = "+ result);
            
        }
    }
}
