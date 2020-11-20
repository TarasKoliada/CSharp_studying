using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static int Sum(int a, int b) //можна задавати будь які імена змінних, потім в основному методі вони автоматично зкопіюються в змінну а і б.
        {
            int result = a + b;
            return result;// або просто a+b, а верхній рядок забрати.
        }
        static void PrintResult(int result) //не повертає значення словом return; він стосується змінної с в головному методі.
        {
            Console.WriteLine("Result: "+ result);
        }
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = Sum(a, b);

            PrintResult(c);
        }
    }
}
