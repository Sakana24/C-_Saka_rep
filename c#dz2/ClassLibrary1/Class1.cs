//Рыбин

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        /// <summary>
        /// Метод, возвращающий минимальное из трех чисел
        /// </summary>
        /// <param name="num1">Первое число</param>
        /// <param name="num2">Второе число</param>
        /// <param name="num3">Третье число</param>
        /// <returns>Минимум трех числе</returns>

        public static int minimum(int num1, int num2, int num3)
        {
            int min;

            if (num1 <= num2 && num1 <= num3)
            {
                min = num1;
            }
            else
                if (num2 <= num3)
            {
                min = num2;
            }
            else
                min = num3;

            return min;
        }

        /// <summary>
        /// Метод подсчета количества знаков числа
        /// </summary>
        /// <param name="number">Число</param>
        /// <returns>Количество знаков</returns>

        public static int counter(int number)
        {
            int count = 0;
            while (number != 0)
            {
                count++;
                number = number / 10;
            }

            return count;
            
        }

        /// <summary>
        /// Метод проверки логина и пароля
        /// </summary>
        /// <param name="userLogin">Логин</param>
        /// <param name="userPassword">Пароль</param>
        /// <returns>Верность введенных данных</returns>

        public static bool check(string userLogin, string userPassword)
        {
            string login = "root";
            string password = "GeekBrains";

            bool res;

            if ((userLogin == login) && (userPassword == password))
            {
                res = true;
            }
            else
                res = false;

            return res;
        }

        /// <summary>
        /// Метод подсчета суммы цифр в числе
        /// </summary>
        /// <param name="a">Исходное число</param>
        /// <returns>Сумма цифр числа</returns>

        public static long RecursiveSum(long a)
        {
            if (a == 0)
                return 0;
            else return RecursiveSum(a / 10) + a % 10;
        }

        /// <summary>
        /// Метод вывода на экран
        /// </summary>
        /// <param name="text">Текст вывода</param>

        public static void Print(string text)
        {
            Console.WriteLine(text);
        }

        /// <summary>
        /// Метод задержки экрана
        /// </summary>

        public static void Pause()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// Метод выводящий на экран числа от a до b
        /// </summary>
        /// <param name="num1">Число a</param>
        /// <param name="num2">Число b</param>
        /// <returns>Рекурсия</returns>

        public static int PrintNumbers(int num1, int num2)
        {
            if (num1 > num2)
                return 0;
            else
                Print(Convert.ToString(num1));
            num1++;
            return PrintNumbers(num1, num2);
        }

        /// <summary>
        /// Метод, возвращающий сумму чисел от a до b
        /// </summary>
        /// <param name="a">Переменная a</param>
        /// <param name="b">Переменная b</param>
        /// <param name="sum">Сумма чисел</param>
        /// <returns></returns>
        public static int RecursiveSumma(int a, int b, int sum = 0)
        {
            if (a == b) 
                return sum + b; 
            else
                sum += a;
            a++;
            return RecursiveSumma(a, b, sum);
        }

    }

}
