using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 10;
            do
            {
                count++;
                Console.WriteLine(count);
            } while (count<10);
        }
    }
}
