using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;

namespace goodnum
{
    class goodnum
    {
        static void Main(string[] args)
        {
            
            int range = 1_000_000_000;

            int count = 0;

            DateTime start = DateTime.Now;
            
            for (int i = 1; i <= range; i++)
            {
                if (i % RecursiveSum(i) == 0)
                {
                    count++;
                    Console.WriteLine(i);
                }else
                    continue;
            }

            Console.WriteLine($"Хороших чисел: {count}"); //61574510 
            DateTime finish = DateTime.Now;
            Console.WriteLine($"Время выполнения программы: {finish - start}");
            Console.ReadKey();
            
           
        }
    }
}
