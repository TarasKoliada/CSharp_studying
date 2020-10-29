using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increment_decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            a = ++a * a;//!!!!!!!(=4) a=a++*a(=2);
            //a++; //це інкремент постфіксна операція
            //int b = 0;
            //b--; //це декримент постфіксна форма
            //префіксна операція --а(навпаки)

            Console.WriteLine(a);
        }
    }
}
