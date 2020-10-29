using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FULLcalculatorIF_ELSE
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
                    Console.WriteLine("Wrong article!!");
                    Console.ReadLine();
                    continue;
                }
               
                Console.WriteLine("Choose operation: '+' '-' '*' '/' ");
                string calculator = Console.ReadLine();
                if (calculator == "+")
                {
                    Console.WriteLine(FirstNum + " + " + SecondNum + " = " + (FirstNum + SecondNum));
                }
                else if (calculator == "-")
                {
                    Console.WriteLine(FirstNum + " - " + SecondNum + " = " + (FirstNum - SecondNum));
                }
                else if (calculator == "*")
                {
                    Console.WriteLine(FirstNum + " * " + SecondNum + " = " + (FirstNum * SecondNum));
                }
                else if (calculator == "/")
                {
                    if (SecondNum == 0)
                    {
                        Console.WriteLine(FirstNum + " / " + SecondNum + " = " + 0);
                    }
                    else
                    {
                        Console.WriteLine(FirstNum + " / " + SecondNum + " = " + "{0:0.00}", (FirstNum / SecondNum));
                    }


                }
                Console.ReadLine();
            }
            
        }
    }
}
