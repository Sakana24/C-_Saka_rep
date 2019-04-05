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
using static Program1.Message;

namespace Program1
{
    static class Message
    {
        /// <summary>
        /// Выводит только те слова сообщения, которые содержат не более n букв.
        /// </summary>
        /// <param name="message">Исходная строка</param>
        /// <param name="n">Максимум символов в слове</param>
        /// <returns>Готовая строка</returns>
        public static string Lim(string message, int n)
        {
            char[] div = { ' ' };
            string[] words = message.Split(div);
            string[] res = new string[words.Length];
            int c = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= n)
                {
                    res[c] = words[i];
                    c++;
                }
            }
            string str = String.Join(" ", res);
            return str;
        }

        /// <summary>
        /// Удаляет слова оканчившиеся на заданный символ
        /// </summary>
        /// <param name="message">Исходный текст</param>
        /// <param name="n">Символ</param>
        /// <returns>Результат</returns>
        public static string RemoveByLastChar(string message, char n)
        {
            char[] div = { ' ' };
            string[] words = message.Split(div);
            string[] res = new string[words.Length];
            int c = 0;

            for (int i = 0; i < words.Length; i++)
            {
                try
                {
                    char[] b = words[i].ToCharArray();
                    int id = b.Length - 1;
                    if (b[id] != n)   //без try catch возвращает ошибку индекс за пределами массива ! (включает пробел в массив)
                    {
                        res[c] = words[i];
                        c++;
                    }
                }
                catch
                {
                    continue;
                }
            }
            string str = String.Join(" ", res);
            return str;
        }
        //догадываюсь, что все решение можно было сделать в разы проще, но я продвигаюсь по с# черепашьим шагом 

        /// <summary>
        /// Возвращает самое длинное слово
        /// </summary>
        /// <param name="message">Исходное сообщение</param>
        /// <returns>Строка из самых линных слов</returns>
        public static StringBuilder LongWord(string message)
        {
            char[] div = { ' ' };
            string[] words = message.Split(div);
            string longOne = words[0];
            int maxLong = words[0].Length;

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > words[i - 1].Length && words[i].Length > maxLong)
                {
                    longOne = words[i];
                    maxLong = words[i].Length;
                }
            }

            StringBuilder str = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == maxLong)
                {
                    str.Append($"{words[i]} ");
                }
            }

            Console.WriteLine($"В самом длинном слове {maxLong} символов");

            return str;
        }
    }

    class Program
    {
        #region Печать массива
        //static void PrintString(string[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write($"{array[i]} ");
        //    }
        //}
        #endregion

        static void Main(string[] args)
        {
            #region задания а, б
            try
            {

                Console.WriteLine("Введите сообщение");
                string message = Console.ReadLine();

                Console.WriteLine("Введите максимальное количество букв в слове");
                int limit = int.Parse(Console.ReadLine());

                Console.WriteLine();

                string result = Lim(message, limit);
                Console.WriteLine(result);

                Console.WriteLine("Введите символ. Слова, оканчившиеся этим символом удалятся");
                char symbol = char.Parse(Console.ReadLine());

                result = RemoveByLastChar(result, symbol);
                Console.WriteLine(result);

            }
            catch
            {
                Console.WriteLine("Возникло исключение");
            }
            #endregion

            #region задания в, г
            Console.WriteLine();
            Console.WriteLine("Введите сообщение");
            string msg = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(LongWord(msg));
            #endregion

            Console.ReadKey();
        }
    }
}
