using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_SWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("You entered the number " + a);
                    }
                break;
                case 2:
                    {
                        Console.WriteLine("You entered the number " + a);
                    }
                break;
                default:
                    Console.WriteLine("You entered the other number "+ a);
                    break;
            }
        }
    }
}
