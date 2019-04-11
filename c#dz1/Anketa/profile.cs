/*1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
     В результате вся информация выводится в одну строчку.
        а) используя склеивание;
        б) используя форматированный вывод;
        в) *используя вывод со знаком $.
        
  Выполнил: Рыбин____________*/

  // ХЕЛП плс ! у миня не роботоит коментарие через "///" !!! Шо мни делать ??? 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Profile.Action;


namespace Profile
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("Вас приветствует программа \"Profile\".\nЧтобы заполнить анкету нажмите любую клавишу.");
            Pause();

            Print("Введите Ваше имя: ");
            string name = Console.ReadLine();

            Print("Введите Вашу фамилию: ");
            string surname = Console.ReadLine();

            Print("Сколько Вам лет? ");
            string age = Console.ReadLine();

            Print("Ваш рост(см): ");
            string hight = Console.ReadLine();

            Print("Ваш вес(кг): ");
            string weight = Console.ReadLine();

            string output = "имя: " + name + "\tфамилия: " + surname + "\tвозраст: " + age + "\tрост: " + hight + "\tвес: " + weight;
            Print(output);

            output = String.Format("имя: {0}\tфамилия: {1}\tвозраст: {2}\tрост: {3}\tвес: {4}",
                                             name,
                                             surname,
                                             age,
                                             hight,
                                             weight);
            Print(output);

            output = $"имя: {name}\tфамилия: {surname}\tвозраст: {age}\tрост: {hight}\tвес: {weight}";
            Print(output);

            Pause();

        }

    }
}
