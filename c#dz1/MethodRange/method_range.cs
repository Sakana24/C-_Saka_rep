// *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
// Рыбин

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Profile.Action;

namespace MethodRange
{
    class method_range
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

            Range(xa, xb, ya, yb);

            Console.WriteLine("Расстояние между точками a и b равно: " + "{0:F}", Range(xa, xb, ya, yb)); //формат не роботоит

            Pause();
        }
    }
}
