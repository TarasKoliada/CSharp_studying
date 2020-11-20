using System;

namespace dotNET_CORE
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {2, 3, 53, 23, 54, 6 };
            Console.WriteLine("Last num of array : "+myArray[^1]+"\n");
            int[] myArray2 = myArray[3..];
            for (int i = 0; i < myArray2.Length; i++)
            {
                Console.WriteLine("from 3 element to last : "+myArray2[i]);
            }
            string str = "hello world !!! =)";
            Console.WriteLine("\n"+str[0]);
            Console.WriteLine("\n"+str[^2..]);
            Console.WriteLine("\n"+str[6..11]);
        }
    }
}
