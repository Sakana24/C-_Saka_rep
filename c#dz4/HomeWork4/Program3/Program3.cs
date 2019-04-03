using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Program3
{
    struct Account
    {
        public Account(string Login, string Password)
        {
            login = Login;
            password = Password;
        }

        public string login;
        public string password;


    }



    class Program3
    {
        /// <summary>
        /// Возвращает массив четных элементов
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Массив логинов</returns>
        public static string[] GetLog(string[] array)
        {
            string[] getlog = new string[array.Length / 2];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    getlog[i / 2] = array[i];
            }
            return getlog;
        }

        /// <summary>
        /// Возвращает массив нечетных элементов
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Массив паролей</returns>
        public static string[] GetPass(string[] array)
        {
            string[] getpass = new string[array.Length / 2];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                    getpass[i / 2] = array[i];
            }
            return getpass;
        }

        /// <summary>
        /// Выводит на консоль массив в строку
        /// </summary>
        /// <param name="array">Массив</param>
        static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i],3}");
            }
        }

        /// <summary>
        /// Проверяет наличие логина 
        /// </summary>
        /// <param name="userLogin">логин, введенный пользователем</param>
        /// <param name="logArr">массив логинов</param>
        /// <returns>логин</returns>
        static string CheckLogin(string userLogin, string[] logArr)
        {
            string trueLog = "false";
            for (int i = 0; i < logArr.Length; i++)
            {
                if (logArr[i] == userLogin)
                    trueLog = logArr[i];
            }
            return trueLog;
        }

        /// <summary>
        /// Возвращает верный пароль для введенного логина
        /// </summary>
        /// <param name="userLogin">Введенный логин</param>
        /// <param name="logArr">Массив логинов</param>
        /// <param name="passArr">Массив паролей</param>
        /// <returns></returns>
        static string GetPass(string userLogin, string[] logArr, string[] passArr)
        {
            string truePass = "false";
            for (int i = 0; i < logArr.Length; i++)
            {
                if (userLogin == logArr[i])
                    truePass = passArr[i];
            }
            return truePass;
        }

        static void Main()
        {
            Console.WriteLine("Вас приветствует моя программа...");
            Console.WriteLine("\n Авторизация: g");
            Console.WriteLine(" Регистрация: r");
            Console.WriteLine();

            Console.SetCursorPosition(14, 4);

            string answer = (Console.ReadLine());

            switch (answer)
            {
                case "g":

                    #region Проверка логина и пароля
                    string[] data = File.ReadAllLines("LoginData.txt");
                    string[] logins = GetLog(data);
                    string[] passwords = GetPass(data);

                    int count = 3;

                    while (count != 0)
                    {
                        Console.WriteLine("Введите логин: ");

                        string userLogin = Console.ReadLine();

                        if (CheckLogin(userLogin, logins) == "false")
                        {
                            Console.WriteLine("Такого логина не существует.");
                            count--;
                            Console.WriteLine($"Попыток осталось {count}");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Введите пароль: ");

                            string userPassword = Console.ReadLine();

                            if (userPassword == GetPass(userLogin, logins, passwords))
                            {
                                Console.WriteLine($"Вы вошли под логином {userLogin}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Пароль неверный");
                                count--;
                                Console.WriteLine($"Попыток осталось {count}");
                                Console.WriteLine();
                            }
                        }
                    }

                    if (count == 0)
                    {
                        Console.WriteLine("Вы исчерпали количество попыток");
                    }
                    #endregion

                    Console.ReadKey();
                    break;

                case "r":

                    #region Регистрация
                    Console.WriteLine(" Введите новый логин");
                    string newLog = Console.ReadLine();

                    Console.WriteLine(" Введите новый пароль");
                    string newPass = Console.ReadLine();

                    using (StreamWriter sw = new StreamWriter(@"LoginData.txt", true))
                    {
                        sw.WriteLine(newLog);
                        sw.WriteLine(newPass);
                    }

                    //Account newAcc = new Account(newLog, newPass);

                    Console.WriteLine($"Вы зарегистрировали аккаунт {newLog}");
                    #endregion

                    Console.ReadKey();
                    break;

                default:
                    break;
            }
        }
    }
}


