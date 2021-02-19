using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2
{
    public class Car
    {
        private int speed = 0;
        public void PrintSpeed()
        {
            if (speed == 0)
            {
                Console.WriteLine("Tha car is standing still");
            }
            else if (speed > 0)
            {
                Console.WriteLine($"The car is movng forward with speed {speed}");
            }
            else if (speed < 0)
            {
                Console.WriteLine($"The car is moving backward with speed {-speed}");
            }
        }
        public void Stop() 
        {
            speed = 0;
        }
        public void DriveForward()
        {
            speed = 60;
        }
        public void DriveBackward()
        {
            speed = -20;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======Car 1======");
            var car1 = new Car();
            car1.DriveBackward();
            car1.PrintSpeed();

            Console.WriteLine("\n======Car 2======");
            var car2 = new Car();
            car2.DriveForward();
            car2.PrintSpeed();

            Console.WriteLine("\n======Car 3======");
            var car3 = new Car();
            car3.Stop();
            car3.PrintSpeed();
        }
    }
}
