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
            string text = "";
            string number;

            Console.WriteLine("Введите числа поочередно. Для результата введите \"0\"");

            while (true)
            {
                number = Console.ReadLine();
                if (number == "0")
                    break;
                else
                {
                    int.TryParse(number, out n);

                    if (n == 0)
                    {
                        Console.WriteLine("Ошибка. Введите число");
                    }
                    else
                    if (n < 0)
                    {
                        continue;
                    }
                    else
                        if (n % 2 == 0)
                    {
                        continue;
                    }
                    else
                        text += Convert.ToString(n) + ", ";
                    sum += n;

                }
            }

            Console.WriteLine($"Сумма положительных нечетных элементов:\n {text} \nравна: {sum}");
            Console.ReadKey();
        }
    }
}
