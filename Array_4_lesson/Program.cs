using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_4_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[,]
            {
                {2, 3, 5, 65, 73 },
                {3, 8, 9, 10, 11 },
                {9, 5, 2, 14, 55 }
            };
            Console.WriteLine("1) "+$"{myArray[0, 2]}"+ " "+ $"{myArray[2, 3]}"+"\n");//виводить 5 i 14
            Console.WriteLine("2) "+myArray[1,4]+"\n ");//виводить 11
            Console.WriteLine("All array: ");
            foreach (var item in myArray)
            {
                Console.WriteLine("\t"+item + " ");
            }

            Console.WriteLine("\nLines: "+myArray.GetLength(0));
            Console.WriteLine("Columns "+myArray.GetLength(1));

            //int height = myArray.GetLength(0);
           // int width = myArray.GetLength(1);
            Console.WriteLine("\nStructured array: ");
            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y, x]+ "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
