using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of dollars or euros: ");
            double DollarsEuros = Convert.ToDouble(Console.ReadLine());
            double HryvniaDollar = DollarsEuros * 28.33;
            double HryvniaEuro = DollarsEuros * 33.26;
            Console.WriteLine(DollarsEuros+" dollars in hryvnias = "+ HryvniaDollar);
            Console.WriteLine(DollarsEuros + " euros in hryvnias = " + HryvniaEuro);
        }
    }
}
