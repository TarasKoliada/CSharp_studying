using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_parameters
{
    class Program
    {
        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
        static void Main(string[] args)
        {
            int result = Sum(b: 4, a: 20);//Призначається значення спочатку в "b", а потім в "а"(Не зважаючи на послідовність).
            Console.WriteLine(result);
        }
    }
}
