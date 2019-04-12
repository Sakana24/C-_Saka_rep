/* а) Написать программу, которая запрашивает массу и рост человека, 
 * вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
 * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/
//Рыбин

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;

namespace imt
{
    class bmi
    {
        static void Main(string[] args)
        {
            Print("Вас приветствует программа \"BMI\".\nЧтобы рассчитать свой индекс массы тела нажмите любую клавишу.");
            Pause();

            Print("Введите Ваш рост(см): ");
            string hight = Console.ReadLine();

            Print("Введите Ваш вес(кг): ");
            string weight = Console.ReadLine();

            float h = Convert.ToSingle(hight) / 100;
            float m = Convert.ToSingle(weight);
            float imt = m / (h * h);

            imt = imt * 100;
            imt = Convert.ToInt32(imt);
            imt = Convert.ToSingle(imt);
            imt = imt / 100;

            string output = $"Ваш индекс массы тела равен {imt} кг/м^2.";
            Print(output);

            float norm = imt * (h * h);
            float imtNormMin = 18.5F;
            float imtNormMax = 24.99F;

            float diff;

            if (imt <= 16)
            {
                diff = (imtNormMin * (h * h)) - m;
                output = $"У Вас серьезный дефицит веса, нкжно набрать {diff:F} кг.";
            }
            else
                if (imt <= 18.5)
            {
                diff = (imtNormMin * (h * h)) - m;
                output = $"У Вас дефицит веса, нужно набрать {diff:F} кг.";
            }
            else
                    if (imt <= 24.99)
                output = "Ваши показатели в норме.";
            else
                        if (imt <= 30)
            {
                diff = m - (imtNormMax * (h * h));
                output = $"У Вас небольшое ожирение, сбросьте {diff:F} кг.";
            }
            else
                            if (imt <= 35)
            {
                diff = m - (imtNormMax * (h * h));
                output = $"У Вас ожирение. Нужно сбросить {diff:F} кг.";
            }
            else
                                if (imt <= 40)
            {
                diff = m - (imtNormMax * (h * h));
                output = $"У Вас резкое ожирение. Нужно сбросить {diff:F} кг.";
            }
            else
            {
                diff = m - (imtNormMax * (h * h));
                output = $"У Вас очень резкое ожирение. Нужно сбросить {diff:F} кг.";
            }

            Print(output);

            Pause();
        }
    }
}
