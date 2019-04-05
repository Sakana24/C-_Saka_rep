#region Задание 2
//а) Дописать класс для работы с одномерным массивом.

//Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами 
//от начального значения с заданным шагом.
//Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, 
//меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент массива на определенное число, 
//свойство MaxCount, возвращающее количество максимальных элементов.В Main продемонстрировать работу класса.
//б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
#endregion
//Рыбин

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Program2
{
    class Program2
    {
        /// <summary>
        /// Возвращает массив из файла
        /// </summary>
        /// <param name="array">Данные в файле</param>
        /// <returns></returns>
        static int[] MyArray(string[] array)
        {
            int myLength = int.Parse(array[0]);
            int myStart = int.Parse(array[1]);
            int myStep = int.Parse(array[2]);

            int[] arr = new int[myLength];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = myStart;
                myStart += myStep;
            }
            return arr;
        }

        /// <summary>
        /// Создает массив с заданными параметрами.
        /// </summary>
        /// <param name="length">Длина</param>
        /// <param name="start">Начало</param>
        /// <param name="step">Интервал</param>
        /// <returns>Готовый массив</returns>
        static int[] MyArray(int length, int start, int step)
        {
            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = start;
                start += step;
            }
            return arr;
        }

        /// <summary>
        /// Выводит на консоль массив в строку
        /// </summary>
        /// <param name="array">Массив</param>
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"    {array[i],3}");
            }
        }

        /// <summary>
        /// Сумма элементов
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Сумма</returns>
        static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        /// <summary>
        /// Создает массив с обратными знаками
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Готовый массив</returns>
        static int[] Inverse(int[] array)
        {
            int[] arr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = -array[i];
            }
            return arr;
        }

        /// <summary>
        /// Создает массив с умноженными элементами
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <param name="factor">Множитель</param>
        /// <returns>Новый массив</returns>
        static int[] Multi(int[] array, int factor)
        {
            int[] arr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i] * factor;
            }
            return arr;
        }

        /// <summary>
        /// Выводит массив в файл в строку
        /// </summary>
        /// <param name="array">Исходный массив</param>
        static void OutPrint(int[] array)
        {

            string[] lines = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                lines[i] = Convert.ToString(array[i]);
            }
            using (StreamWriter sw = new StreamWriter(@"outData.txt", true))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    sw.Write($"  {lines[i],3}");
                }
                sw.WriteLine();
            }
        }

        /// <summary>
        /// Возвращает количество максимальных элементов
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Количество макимальных элементов</returns>
        static int MaxCount(int[] array)
        {
            int max = array[0];
            int count = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1] || array[i] >= max)
                    max = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                    count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            #region Ввод данных с консоли 
            Console.WriteLine("Введите количество элементов массива ");
            int userLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите начало массива ");
            int userStart = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите интервал: ");
            int userStep = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите множитель: ");
            int userFactor = int.Parse(Console.ReadLine());
            #endregion 

            #region Запись данных в исходный файл
            using (StreamWriter sw = new StreamWriter(@"arrayData.txt"))
            {
                sw.WriteLine($"{userLength}");
                sw.WriteLine($"{userStart}");
                sw.WriteLine($"{userStep}");
                sw.WriteLine($"{userFactor}");
            }
            #endregion //чтобы программа читала сразу из файла закомментируйте этот и предидущий регионы

            #region Создание массива по данным из файла
            string[] data = File.ReadAllLines("arrayData.txt");

            int[] arr = MyArray(data);
            //int[] arr = MyArray(userLength, userStart, userStep);

            int factor = int.Parse(data[3]); //здесь множитель пришлось указать 
            #endregion

            #region Вывод на консоль
            Console.WriteLine("\nЗадан массив: ");
            PrintArray(arr);

            Console.WriteLine($"\n\nСумма элементов: {Sum(arr)}");

            Console.WriteLine("\nИнверсия: ");
            PrintArray(Inverse(arr));

            Console.WriteLine($"\n\nУмножаем на {factor}: ");
            PrintArray(Multi(arr, factor));

            Console.WriteLine($"\n\nМакимальных элементов: {MaxCount(arr)}");

            #endregion

            #region Вывод в производный файл
            using (StreamWriter sw = new StreamWriter(@"outData.txt"))
            {
                sw.WriteLine("Задан массив: ");
            }
            OutPrint(arr);
            using (StreamWriter sw = new StreamWriter(@"outData.txt", true))
            {
                sw.WriteLine();
                sw.WriteLine($"Cумма элементов: {Sum(arr)}");
                sw.WriteLine();
                sw.WriteLine($"Инверсия: ");
            }
            OutPrint(Inverse(arr));
            using (StreamWriter sw = new StreamWriter(@"outData.txt", true))
            {
                sw.WriteLine();
                sw.WriteLine($"\nУмножаем на {factor}: ");
            }
            OutPrint(Multi(arr, factor));
            using (StreamWriter sw = new StreamWriter(@"outData.txt", true))
            {
                sw.WriteLine();
                sw.WriteLine($"\nМаксимальных элементов: {MaxCount(arr)}");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
