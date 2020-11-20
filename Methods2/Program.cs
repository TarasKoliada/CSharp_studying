using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {

        static void Result(string result, uint symbolCount)
        {
            for (int i = 0; i < symbolCount; i++)
            {
                Console.Write(result);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter symbol: ");
            string a = Console.ReadLine();
            Console.WriteLine("Enter number of symbols: ");
            uint b = uint.Parse(Console.ReadLine());
            Result(a, b);
            Console.ReadLine();
        }
    }
}
