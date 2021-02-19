using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;// перевіряєм i на null     цей інт є nullable
            Console.WriteLine(i == null);//True

            Console.WriteLine(i.HasValue);//False

            Console.WriteLine(i.GetValueOrDefault(3));//3  команда виводить значення змінної і, а якщо там null то виводить дефолт(в цьому випадку 3)

            Console.WriteLine(i ?? 55);//55     таке саме як GetValueOrDefault(). прога перевіряє значення і, якщо там null то виводить 55.

            Console.WriteLine(i.Value);//InvalidOperationExeption
        }
    }
}
