using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_resize_array
{
    class Program
    {
        static void Resize(ref int[] array, int newSize)
        {
            Random random = new Random();
            int[] newArray = new int[newSize];//створюєм масив на введену користувачем кількість елементів

            for (int i = 0; i < array.Length && i < newArray.Length; i++)//копіюєм в новий масив елементи з старого масива
            {
                newArray[i] = array[i];
            }

            array = newArray;//видаляєм ссилку старого масива та передаєм значення масива у новий масив

            Console.WriteLine("\nChanged size of array: ");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(" | " + newArray[i]);

            }
            Console.WriteLine();

            Console.WriteLine("\nDo you want to fill the rest of array with random numbers? ");
            Console.Write("Your answer: ");
            string answer = Console.ReadLine();
            if (answer == "yes" || answer == "Yes" || answer == "YES")
            {
                Console.WriteLine("\nFiiling the rest of array with random numbers: ");
                for (int i = 0; i < array.Length && i <= 2; i++)
                {
                    Console.Write(" | " + array[i]);
                }
                for (int j = 3; j < newArray.Length; j++)
                {
                    newArray[j] = random.Next(1, 20);
                    Console.Write(" | " + newArray[j]);
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("Okay :)");
        }
        static void Insert(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            array = newArray;

            Console.WriteLine("Changed array: ");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(" | " + newArray[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the task: \n Task 1: Changing size of array;\n Task 2: Adding other number to array;\n");
            Console.Write("Your choise: ");
            int choosing = int.Parse(Console.ReadLine());
            switch (choosing)
            {
                case 1:
                    int[] myArray = { 1, 4, 6 };
                    Console.WriteLine("Initial array: ");
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        Console.Write(" | " + myArray[i]);
                    }
                    Console.Write("\nChange size of array to: ");
                    int size = int.Parse(Console.ReadLine());
                    Resize(ref myArray, size);
                    break;
                case 2:

                    Console.WriteLine("\nTask 2\n Our array: ");
                    int[] myArray2 = new int[10];
                    Random random = new Random();
                    for (int i = 0; i < myArray2.Length; i++)
                    {
                        myArray2[i] = random.Next(1, 20);
                        Console.Write(" | " + myArray2[i]);
                    }

                    Console.Write("\nEnter index of array to add: ");
                    int index = int.Parse(Console.ReadLine());
                    Console.Write("\nEnter value you want to add: ");
                    int value = int.Parse(Console.ReadLine());
                    Insert(ref myArray2, value, index);
                    break;
            }
        }
    }
}
