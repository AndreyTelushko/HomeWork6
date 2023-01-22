using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Program
    {
        static void Main()
        {
            double x = 0;
            double y = 0;
            Console.Write("Введите значение b1: ");
            double b1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение k1: ");
            double k1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение b2: ");
            double b2 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение k2: ");
            double k2 = int.Parse(Console.ReadLine());
            FindCrossVector(b1, k1, b2, k2, ref x, ref y); ;
            Console.WriteLine($"Линии пересекутся в точке [{Math.Round(x, 2)} ; {Math.Round(y, 2)}]");
        }

        public static void FindCrossVector(double b1, double k1, double b2, double k2, ref double x, ref double y)
        {
            x = (-b2 + b1) / (-k1 + k2);
            y = k2 * x + b2;
        }

    }
}
