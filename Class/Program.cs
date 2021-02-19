using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    enum Color
    {
        Blue,
        Green,
        White,
        Yellow
    }
    class Point
    {
        public int x;
        public int y;
        public Color color;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.x = 4;
            point.y = 2;
            point.color = Color.Green;
            Console.WriteLine($"X: {point.x}; Y: {point.y}; Color: {point.color}");
        }
    }
}
