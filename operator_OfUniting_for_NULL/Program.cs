using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_OfUniting_for_NULL
{

    class Program
    {
        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }
        static void Main(string[] args)
        {
            string str = null;
            Console.WriteLine(str ?? "No data");//Виведе на екран No data 

            string str2 = "\nTest";
            Console.WriteLine(str2 ?? "No data");//Виведе на екран Test

            string str3 = null;
            string result = str3 ?? string.Empty;//присвоює пусте значення 
            Console.WriteLine("\nCount of nums: " + result.Length);//виведе на екран 0

            string str4 = "Text";
            str4 ??= string.Empty;//перевіряє чи не має str4 значення null, кщо має то в str4 присвоює значення після оператору ??=, в цьому випадку 0.
            Console.WriteLine("\nCount: "+ str4.Length);//виведе на екран 4, бо слово Text має 4 букви.

            int[] myArray = GetArray();
            Console.WriteLine("Sum of nums of array: "+ (myArray?.Sum() ?? 0));// перевіряє значення масива, якшо там null, то виведе дефолтне знач 0, якшо числа, то суму.
        }
    }
}
