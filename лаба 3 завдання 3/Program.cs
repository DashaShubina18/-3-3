using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_3_завдання_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3.5; //початок проміжку
            double b = 10.5; //кінець проміжку
            double h = 0.2; //відступ 
            double e = 2.72;
            Console.WriteLine("x\t\ty\t\tz"); //заголовок таблиці з табуляціями
            for (double x = a; x <= b; x += h)
            {
                double y = Math.Cos(1.5 * x) * Math.Log10(2.5 * x);
                double z = Math.Pow(e, 1 / Math.Sqrt(x)) * Math.Sin(x);

                Console.WriteLine($"{x:F2}\t\t {y:F6}\t\t {z:F6}");
            }
            Console.ReadKey();


        }
    }
}
