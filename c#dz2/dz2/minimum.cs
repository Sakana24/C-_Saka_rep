// Написать метод, возвращающий минимальное из трех чисел.
// Рыбин

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;

namespace dz2
{
    class minimum
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int a = r.Next(100);
            int b = r.Next(100);
            int c = r.Next(100);

            Console.WriteLine($"Из чисел {a}, {b}, {c} минимальное число: {minimum(a, b, c)}");
            Console.ReadKey();

        }
    }
}
