/*а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) Сделать задание, только вывод организуйте в центре экрана
в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
*/
// Рыбин
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitka
{
    class person
    {
        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            string name = "Трэвис Скотт";
            string city = "Майами";

            Print(name, 30, 10);
            Print(city, 33, 12);

            Console.ReadKey();

        }
    }
}
