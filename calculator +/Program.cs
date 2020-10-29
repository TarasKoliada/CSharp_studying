using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int a;
            int b;
            Console.WriteLine("введите число 1");
            text = Console.ReadLine();
            a = Convert.ToInt32(text);
            Console.WriteLine("Введите число 2");
            text = Console.ReadLine();
            b = Convert.ToInt32(text);
            int result = a + b;
            Console.WriteLine("Сума чисел" + result);
        }
    }
}
