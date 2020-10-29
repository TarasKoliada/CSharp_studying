using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FULLcalculatorSWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
               
                Console.Clear();
                double FirstNum, SecondNum;
         
                try
                {
                    Console.WriteLine("Enter first num: ");
                     FirstNum = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second num: ");
                     SecondNum = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong argument!!!");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("Choose operation: '+' '-' '*' '/' ");
                string calculator = Console.ReadLine();

                switch (calculator)
                {
                    case "+":
                        Console.WriteLine(FirstNum + " + " + SecondNum + " = " + (FirstNum + SecondNum));

                    break;
                    case "-":
                        Console.WriteLine(FirstNum + " - " + SecondNum + " = " + (FirstNum - SecondNum));
                    break;
                    case "*":
                        Console.WriteLine(FirstNum + " * " + SecondNum + " = " + (FirstNum * SecondNum));
                    break;
                    case "/":
                        if (SecondNum == 0)
                        {
                            Console.WriteLine(FirstNum + " / " + SecondNum + " = 0");
                        }
                        else
                            Console.WriteLine(FirstNum + " / " + SecondNum + " = " + "{0:0.00}", (FirstNum / SecondNum));

                    break;
                    default:
                        Console.WriteLine("Warning. Wrong argument!!!");
                    break;
                }
                Console.ReadLine();
            
                  


            }
            
        }
    }
}
