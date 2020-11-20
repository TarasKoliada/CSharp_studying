using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Array_from_keyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 3];
            int a = 0;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (  int j = 0; j < myArray.GetLength(1); j++)
                {
                    a++;
                    Console.WriteLine("Enter "+ a +" value of array: ");
                    myArray[i, j] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("Recieved array: ");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j]+ "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
