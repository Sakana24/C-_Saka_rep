/* a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
 * б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.*/
//Рыбин

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;

namespace recurs1
{
    class recurse1
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int a = r.Next(20);
            int b = r.Next(20, 30);

            Console.WriteLine($"a = {a}, b = {b}");

            PrintNumbers(a, b);

            Pause();

            RecursiveSum(a, b);

            Print($"Сумма чисел равна: {RecursiveSum(a, b)}");

            Pause();

        }
    }
}
