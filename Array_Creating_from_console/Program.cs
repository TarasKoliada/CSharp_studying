using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Creating_from_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("Enter amount of the array you want to create: ");
            int ArrCount = int.Parse(Console.ReadLine());
            int[] myArray = new int[ArrCount];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"\nEnter count of {i} element:");
                 myArray[i] = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("\nCreated array: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
                Console.WriteLine("\nReverced array: ");
            for (int i = myArray.Length - 1; i >= 0; i--)
            {

                Console.WriteLine(myArray[i]);
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                if(myArray[i] % 2 == 0 )
                {
                    result += myArray[i];
                }
            }
            int minValue = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i]< minValue)
                {
                    minValue = myArray[i];
                }
            }
            int maxValue = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] > minValue)
                {
                    maxValue = myArray[i];
                }
            }
            Console.WriteLine("\n The least num of array : " + minValue+"\n");
            Console.WriteLine("\n The biggest num of array : " + maxValue+"\n");
            Console.WriteLine("\nSum of even nums of array: " + result+"\n");


        }
    }
}
