using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    public enum Color
    {
        Blue,
        White,
        Green,
        Yellow,
        Purple
    }
    public class Point
    {
        public int x;//поля класу
        public int y;
        public int z;
        public Color color;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
                p1.x = 3;
                p1.y = 6;
                p1.z = 10;
                p1.color = Color.Green; 
                Console.WriteLine($"X: {p1.x}; Y: {p1.y}; Z: {p1.z}; Color: {p1.color}");
            
            
            

        }
    }
}
