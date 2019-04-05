//2. Разработать статический класс Message, содержащий следующие статические методы для
//обработки текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.//Рыбин

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Login
    {
        static bool CheckRange(string text)
        {
            return (text.Length >= 2 && text.Length <= 10);
        }

        static bool CheckFirstSymbol(string text)
        {
            char[] log = text.ToCharArray();
            return (char.IsNumber(log[0]) != true);
        }

        static bool CheckLetters(string text)
        {
            char[] log = text.ToCharArray();
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetterOrDigit(log[i]))
                    count++;
            }
            return (count == text.Length);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите логин: ");
                string userLogin = Console.ReadLine();

                try
                {
                    if (CheckRange(userLogin) == false)
                        Console.WriteLine("Логин должен содержать от 2х до 10ти символов");
                    else if (CheckFirstSymbol(userLogin) == false)
                        Console.WriteLine("Первый символ логина должен быть буквой");
                    else if (CheckLetters(userLogin) == false)
                        Console.WriteLine("Логин должен содержать только буквы и цифры");
                    else Console.WriteLine("Пароль подходит");
                }
                catch
                {
                    Console.WriteLine("Возникло исключение");
                }
            }

        }
    }
}
