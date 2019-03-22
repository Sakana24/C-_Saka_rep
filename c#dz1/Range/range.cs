/*а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
 * по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
 * Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);*/
 // Выполнил Рыбин
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Profile.Action;

namespace Range
{
    class range
    {
        static void Main(string[] args)
        {
            Print("Введите координаты точек a и b: ");

            Print("x(a) = ");
            var xa = Console.ReadLine();
            double x1 = Convert.ToDouble(xa);

            Print("y(a) = ");
            var ya = Console.ReadLine();
            double y1 = Convert.ToDouble(ya);

            Print("x(b) = ");
            var xb = Console.ReadLine();
            double x2 = Convert.ToDouble(xb);

            Print("y(b) = ");
            var yb = Console.ReadLine();
            double y2 = Convert.ToDouble(yb);

            double range = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между точками a и b равно: " + "{0:F}", range);
            Pause();
        }
    }
}
