//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
//Рыбин

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summa
{
    class summa
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;
            Console.WriteLine("Введите числа поочередно. Для результата введите \"0\"");
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    continue;
                } else
                    if (n % 2 == 0)
                {
                    continue;
                }else
                    sum += n;
            }
            while (n != 0);

            Console.WriteLine($"Сумма положительных нечетных элементов равна: {sum}");
            Console.ReadKey();
        }
    }
}
