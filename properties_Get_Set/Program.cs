using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties_Get_Set
{
    public class Point
    {



        

        public int y { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Point();
            p.X = 10;
            int x = p.X;
            p.y = 20;
            Console.WriteLine($"{ x}, { p.y}");

        }
    }
}
