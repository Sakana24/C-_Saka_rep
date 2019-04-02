#region Задание 1
//1. Дан целочисленный массив из 20 элементов.
//Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
//Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
//В данной задаче под парой подразумевается два подряд идущих элемента массива.
//Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
#endregion
//Рыбин

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program1
    {
        /// <summary>
        /// Заполнияет массив случайными числами в диапазоне значений
        /// </summary>
        /// <param name="data">Массив</param>
        /// <param name="minValue">Минимум значений</param>
        /// <param name="maxValue">Максимум значений</param>
        static void FillArray(ref int[] data, int minValue, int maxValue)
        {
            Random r = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = r.Next(minValue, maxValue);
            }
        }

        /// <summary>
        /// Считает пары, в которых хотя бы 1 элемент % 3 = 0;
        /// </summary>
        /// <param name="data">Массив</param>
        /// <returns>Число пар</returns>
        static int Counter(int[] data)
        {
            int count = 0;
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] % 3 == 0 || data[i - 1] % 3 == 0)
                    count++;
                //Console.WriteLine($"{data[i]}, {data[i - 1]}");
            }
            return count;
        }

        static void Main(string[] args)
        {
            int length = 20;
            int[] array = new int[length];

            int min = -10_000;
            int max = 10_000;

            FillArray(ref array, min, max);

            Console.WriteLine("Массив: ");

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($" {array[i]}");
            }

            Console.WriteLine($"\nКоличество пар: {Counter(array)}");
            Console.ReadKey();

        }
    }
}
