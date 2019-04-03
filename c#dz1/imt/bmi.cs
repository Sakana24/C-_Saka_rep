/*2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах*/
//Рыбин

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Profile.Action;

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

            float h = System.Convert.ToSingle(hight) / 100;
            float m = System.Convert.ToSingle(weight);
            float imt = m / (h * h);

            imt = imt * 100;
            imt = System.Convert.ToInt32(imt);
            imt = System.Convert.ToSingle(imt);
            imt = imt / 100;

            string output = $"Ваш индекс массы тела равен {imt} кг/м^2.";
            Print(output);

            if (imt <= 16)
                output = "Ну ты кащей...";
            else
                if (imt <= 18.5)
                output = "Останьтесь дома, на улице сильный ветер.";
            else
                    if (imt <= 24.99)
                output = "Ваши показатели в норме.";
            else
                        if (imt <= 30)
                output = "Го в макдак.";
            else
                            if (imt <= 35)
                output = "У Вас ожирение.";
            else
                                if (imt <= 40)
                output = "У Вас резкое ожирение.";
            else
                output = "Даже моя мамаша не такая жирная, соберись, чувак";

            Print(output);

            Pause();
        }
    }
}
