/*Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу: 
 * пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.*/
 //Рыбин

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;

namespace login
{
    class login
    {
        static void Main(string[] args)
        {   
            int count = 3;
            
            do
            {
                Console.WriteLine("Введите логин: ");
                string uLog = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                string uPass = Console.ReadLine();

                check(uLog, uPass);

                if (check(uLog, uPass) == true)
                {
                    Console.WriteLine("Вы прошли.");
                    break;
                }
                else
                    count--;
                    if (count != 0) {
                        Console.WriteLine($"Попробуйте еще раз. Попыток осталось: {count}");
                    }else
                        Console.WriteLine("Вы исчерпали количество попыток");
                

            } while (count != 0);

           

            Console.ReadKey();
           
        }
    }
}
