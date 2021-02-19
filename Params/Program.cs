using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static int Sum(params int[] parameters)//передаєм в метод не масив чисел, а самі числа завдяки слову params.
        {
            int result = 0;
            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            int result = Sum(4, 6, 3, 3, 6);//Можна передати скільки хочеш числ
            Console.WriteLine(result);
        }
    }
}
