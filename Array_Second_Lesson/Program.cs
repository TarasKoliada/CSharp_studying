using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Second_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10 , 104, 54, 87 };
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine("__________________");
            
            for (int i = myArray.Length -1; i >= 0; i--)
            {
                
                Console.WriteLine(myArray[i]);
            }
            Console.ReadKey();
            /*Array.Reverse(myArray);
             * for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }--те саме
             * 
             */
        }
    }
}
