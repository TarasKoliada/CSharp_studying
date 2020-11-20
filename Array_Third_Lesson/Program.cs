using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Third_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] myArray = { 12, 423, 873, 34, 428, 1};
            Console.WriteLine("Min num "+myArray.Min());
            Console.WriteLine("MAx num "+myArray.Max());
            Console.WriteLine("Sum of all "+myArray.Sum());
            Console.WriteLine("Sum of even "+myArray.Where(i => i % 2 == 0).Sum());
            Console.WriteLine("Sum of not even "+myArray.Where(i => i % 2 != 0).Sum());

            int[] myArr = { 111, 111, 284, 284, 473, 948, 473, 21, 21 };
            int[] result = myArr.Distinct().ToArray();
            int[] res = myArr.OrderByDescending(i=>i).ToArray();
            Console.WriteLine("Deleted repeated nums");
           for (int i = 0; i < result.Length; i++)
           {
                Console.WriteLine(result[i]);
           }
            Console.WriteLine("From bigger to smaller");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(" "+res[i]);
            }
            Console.WriteLine("Sorted from smaller to bigger");
            Array.Sort(myArray);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("  "+myArray[i]);
            }
           

        }
    }
}
