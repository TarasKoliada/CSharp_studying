using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigitsNumbers
{
    class Program
    {
        static int Foo(int value)
        {
            if (value < 10)
                return value;
            int digit = value % 10;//відкидаємо останню цифру
            int nextValue = value / 10;//знаходимо наступне значення
            return digit + Foo(nextValue);//через рекурсію пробігаєм по методу заново з новими цифрами
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            int myValue = int.Parse(Console.ReadLine());
            int result = Foo(myValue);
            Console.WriteLine($"Sum of digits of number: {result}");
        }
    }
}
