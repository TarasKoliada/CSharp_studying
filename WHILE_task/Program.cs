using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHILE_task
{
    class Program
    {
        static void Main(string[] args)
        {
            uint oddNum = 0;
            uint evenNum = 0;
            int oddSum = 0;
            int evenSum = 0;
            Console.WriteLine("Enter the first num of your range");
            int currentValue = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the last num of your range");
            int lastValue = int.Parse(Console.ReadLine());
            while (currentValue <= lastValue) 
            {
               

                if (currentValue % 2 == 0)
                {
                    evenNum++;
                    evenSum = evenSum + currentValue;
                }
                else
                {
                    oddNum++;
                    oddSum = oddSum + currentValue;
                }
                currentValue++;
                    

                
            }

            Console.WriteLine("Number of even numbers : "+ evenNum);
            Console.WriteLine("Number of odd numbers : " + oddNum);
            Console.WriteLine("Sum of even numbers : " + evenSum);
            Console.WriteLine("Sum of odd numbers : " + oddSum);
            Console.ReadLine();
        }
    }
}
