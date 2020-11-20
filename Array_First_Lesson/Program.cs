using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_First_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray;
            MyArray = new int[2];
              Console.WriteLine("Fill the first array: ");
            MyArray[0] = int.Parse(Console.ReadLine());
              Console.WriteLine("Fill the second array: ");
            MyArray[1] = int.Parse(Console.ReadLine());
              int sum = MyArray[0] + MyArray[1];
              Console.WriteLine(MyArray[0] + " + " + MyArray[1] + " = " + sum);
              Console.WriteLine("Amount of these array is: " + MyArray.Length);


            /* int [] = Enumerable.Repeat(5, 10).ToArray(); ---> ств 10 елементів масив і всі вони будуть мати значення 5
             * int [] = Enumerable.Range(4, 5).ToArray(); ----ств 5 елементів масива і вони будуть починатись з значення 4----MyArray[0]=4; MyArray[1]=5 і тд.

             */

        }
    }
}
