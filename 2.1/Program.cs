using System;

namespace _2._1
{
    class Program
    {
        static double E = 0.001;
        static double Recurs(int k, double x)
        {
            if (!Convert.ToBoolean(k)) return 1;
            return 0.5 * (Recurs(k - 1, x) + x / Recurs(k - 1, x));
        }
        static double Square(double x, int k)
        {
            double res = Recurs(k,x);
            if (Math.Abs(res*res-x)< E)
            {
                return res;
            }
            return Square(x,k+1);
        }
        static void Main(string[] args)
        {
            double x = 0.61;
            double a = 16.5;
            double b = 3.4;
            System.Console.WriteLine("Задание №1");
            System.Console.WriteLine($"s = {Math.Pow(x, 3) * Math.Pow(Math.Tan(x + b), 2) + a / (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)))}");
            System.Console.WriteLine($"d = {(b * Math.Pow(x, 2) - a) / (Math.Pow(Math.E, a * x) - 1)}");
            System.Console.WriteLine();

            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите x");
            int an = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень k");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine(Square(an, n));
        }
    }
}
