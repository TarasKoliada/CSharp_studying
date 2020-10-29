using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_SWITCH2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a =Console.ReadLine();
            switch (a)
            {
                case "hello":
                    {
                        Console.WriteLine("You entered the word " + a);
                    }
                    break;
                case "hi":
                    {
                        Console.WriteLine("You entered the word " + a);
                    }
                    break;
                case "+":
                    {
                        Console.WriteLine("You entered the word " + a);
                    }
                    break;
                default:
                    Console.WriteLine("You entered an unknown word ");
                    break;
            }
        }
    }
}
