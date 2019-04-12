/*4. Написать программу обмена значениями двух переменных.
а) с использованием третьей переменной;
б) *без использования третьей переменной.*/
//Рыбин

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changer
{
    class swap
    {
        static void Main(string[] args)
        {
            //c 3й переменной
            var a = 0;
            var b = 1;

            var c = a;
            a = b;
            b = c;

            //без 3й переменной скатал с гугла но был близок
            a = a + b;
            b = a - b;
            a = a - b;

                 
        }

    }
}
