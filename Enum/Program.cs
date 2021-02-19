using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                int KeyCode = (int)key;
                Console.WriteLine($"\nEnum {key}\tKey Code {KeyCode}");

                if (key == ConsoleKey.Enter)
                {
                    break;
                   // Console.WriteLine("Enter");
                }
            }
        }
    }
}
