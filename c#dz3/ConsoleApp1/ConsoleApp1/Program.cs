using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Complex
    {
        public double im;
        public double re;
        
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }       
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);

            Console.WriteLine(result.ToString());

            result = complex1.Minus(complex2);

            Console.WriteLine(result.ToString());
        
            result = complex1.Multi(complex2);

            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
