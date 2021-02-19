using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    class Program
    {
        static int Sum(int[] Arr, int i = 0)
        {
            if (i>=Arr.Length)
            {
                return 0;
            }
            int result = Sum(Arr, i + 1);
            
            return Arr[i] + result;
        }
        static void PrintArr(int []Arr, int i = 0)
        {
            if (i < Arr.Length)
            {
                
                Console.WriteLine(Arr[i]);
                PrintArr(Arr, i + 1);
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] Arr = new int[5];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = random.Next(20);
            }
            Console.WriteLine("Array: ");
            PrintArr(Arr);
            int result = Sum(Arr);
            Console.WriteLine($"Sum : {result}");
        }
    }
}
