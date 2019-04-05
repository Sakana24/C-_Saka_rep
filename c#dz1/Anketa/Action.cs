/*6. * Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
Достаточно решить 3 задачи.Записывайте в начало программы условие и свою фамилию.
Все программы создавайте в одном решении.Задания со звездочками выполняйте в том случае, если вы решили задачи без звездочек.*/
//Рыбин

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile
{
    class Action
    {
        public static void Pause()
        {
            Console.ReadKey();
        }

        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        public static string Range(string xa, string xb, string ya, string yb)
        {

            double x1 = Convert.ToDouble(xa);
              
            double y1 = Convert.ToDouble(ya);

            double x2 = Convert.ToDouble(xb);
                        
            double y2 = Convert.ToDouble(yb);

            double range = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            string r = Convert.ToString(range);
            return r;
            
        }  
        
        

    }
}
