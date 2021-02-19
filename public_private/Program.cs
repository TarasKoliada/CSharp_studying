using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_private
{
    public class Point
    {
        private int x = 1;
        private int y = 4;
        private void PrintX()//клас програм не має доступу до цього методу
        {
            Console.WriteLine($"X: {x}");
        }
        private void PrintY()//клас програм не має доступу до цього методу
        {
            Console.WriteLine($"Y: {y}");
        }
        public void PrintPoint()//публічний метод, він має доступ до приватних х і у
        {
            PrintX();
            PrintY();
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Point();
            p.PrintPoint();
        }
    }
}
