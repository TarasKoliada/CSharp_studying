using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodavannia_mnozhennia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first num: ");
                double FirstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second num: ");
                 double SecondNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third num: ");
                  double ThirdNum = Convert.ToDouble(Console.ReadLine());
            double suma = FirstNum + SecondNum + ThirdNum;
            double dobutok = FirstNum * SecondNum * ThirdNum;
            Console.WriteLine("Sum of your nums = "+ suma);
            Console.WriteLine("Product of your nums = "+ dobutok);
            Console.ReadKey();
        }
    }
}
