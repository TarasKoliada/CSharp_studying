using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 1; a++)
            {
                Console.WriteLine("#");
                for (int b = 0; b < 1; b++)
                {
                    Console.WriteLine("##");
                    for (int c = 0; c < 1; c++)
                    {
                        Console.WriteLine("###");

                    }

                }
                for (int b = 0; b < 1; b++)
                {
                    Console.WriteLine("####");

                }
            }
        }
    }
}
