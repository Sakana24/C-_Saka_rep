//3. Переделать программу Пример использования коллекций для решения следующих задач:
//а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
//б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный
//массив);
//в) отсортировать список по возрасту студента;
//г) * отсортировать список по курсу и возрасту студента;
//Рыбин


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace students1
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;

        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.group = group;
            this.city = city;
        }
    }

    class Program
    {
        //static int MyDelegat(Student st1, Student st2)
        //{
        //    return string.Compare(st1.firstName, st2.firstName);
        //}

        static int Age(Student st1, Student st2)
        {
            return string.Compare(st1.age.ToString(), st2.age.ToString());
        }

        static void Main(string[] args)
        {
            int bakalavr = 0;
            int magistr = 0;
            int oldy = 0;

            List<Student> list = new List<Student>();

            DateTime dt = DateTime.Now;

            StreamReader sr = new StreamReader("students_1.csv");

            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));

                    if (int.Parse(s[6]) > 5) magistr++; else bakalavr++;
                    if (int.Parse(s[6]) == 5 || int.Parse(s[6]) == 6) oldy++;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка! ESC - прекратить выполнение программы.");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            Console.WriteLine($"Всего студентов: {list.Count}");
            Console.WriteLine($"Магистров: {magistr}");
            Console.WriteLine($"Бакалавров: {bakalavr}");
            Console.WriteLine($"Студентов на 5 и 6 курсах: {oldy}");
            list.Sort(new Comparison<Student>(Age));
            foreach (var v in list) Console.WriteLine($"age {v.age} {v.firstName}");
            Console.WriteLine();
            Console.WriteLine("Студенты от 18ти до 20ти: ");

            foreach (var v in list)
            {
                if (v.age >= 18 && v.age <= 20)
                    Console.WriteLine($"course {v.course} {v.firstName} {v.age}");
            }

            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }
}
