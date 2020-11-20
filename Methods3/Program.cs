using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Program
    {
        static int IndexOf(int[] array, int value) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ( array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        static int[] GetRandomArray(uint length, int minValue, int maxValue)
        {
            int[] myArray = new int[length];
            Random random = new Random();
            for (int randNum = 0; randNum < myArray.Length; randNum++)
            {
                myArray[randNum] = random.Next(minValue, maxValue);
            }
            return myArray;
        }
        static void Main(string[] args)
        {
            uint length;
            int minValue;
            int maxValue;
            Console.WriteLine("Enter length of your array: ");
            length = uint.Parse(Console.ReadLine());

            Console.WriteLine("Enter minimal value of your array: ");
            minValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter max value of your array: ");
            maxValue = int.Parse(Console.ReadLine());

            int[] myArray = GetRandomArray(length, minValue, maxValue);

            Console.WriteLine("Your array: ");
            for (int arrnum = 0; arrnum < myArray.Length; arrnum++)
            {
                Console.Write(myArray[arrnum]+" ");
            }

            Console.WriteLine("\nEnter num: ");
            int enter = int.Parse(Console.ReadLine());

            int result = IndexOf(myArray, enter);
            Console.WriteLine("Index of this num is: "+result);
        }
    }
}
