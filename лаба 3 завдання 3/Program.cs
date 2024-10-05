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
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|         x        |            y        |         z       |"); //заголовок таблиці з табуляціями
            Console.WriteLine("------------------------------------------------------------");
           
            for (double x = a; x <= b; x += h)
            {
                double y = Math.Cos(1.5 * x) * Math.Log10(2.5 * x);
                double z = Math.Pow(e, 1 / Math.Sqrt(x)) * Math.Sin(x);

                 Console.WriteLine($"|   {x,6:F2}         |   {y,12:F6}      |    {z,10:F6}   |");
            }
            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadKey();


        }
    }
}
