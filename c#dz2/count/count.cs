//Написать метод подсчета количества цифр числа.
//Рыбин

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;

namespace count
{
    class count
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"В этом числе {counter(n)} знаков");
            Console.ReadKey();
        }
    }
}
