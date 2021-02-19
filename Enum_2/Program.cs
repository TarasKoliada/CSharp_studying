using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_2
{
    class Program
    {
        enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static DayOfWeek GetNextDay(DayOfWeek day)
        {
            if (day < DayOfWeek.Sunday)
            {
                return day + 1;
            }
            return DayOfWeek.Monday;
        }
        static void Main(string[] args)
        {
           
            // Console.WriteLine(dayOfWeek);
            // Console.WriteLine((DayOfWeek)3);
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine((DayOfWeek)i);
            }
            Console.WriteLine("\n"+ Enum.GetUnderlyingType(typeof(DayOfWeek)));

            DayOfWeek dayOfWeek = DayOfWeek.Monday;
            Console.WriteLine("\n" + dayOfWeek +"\n");

            DayOfWeek nextDay = GetNextDay(dayOfWeek);
            Console.WriteLine(nextDay);
        }
    }
}
