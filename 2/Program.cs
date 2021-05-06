using System;

namespace _2
{
    class Program
    {
        static double Integral(int n, double a, double x)
        {
            if (n > 1)
            {
                return (Math.Pow(x, n) * Math.Pow(Math.E, a * x)) / a - (n / a) * Integral(n - 1, a, x);
            }
            else if (n == 1)
            {
                return (Math.Pow(Math.E, a * x) / Math.Pow(a, 2)) * (a * x - 1);
            }
            return 0;
        }
        static void Main(string[] args)
        {
            double x = 0.2;
            double a = 1.1;
            double b = 0.04;
            System.Console.WriteLine("Задание №1");
            System.Console.WriteLine($"y = {Math.Pow(Math.Sin(Math.Pow(Math.Pow(x, 2) + a, 2)), 3) - Math.Sqrt(x / b)}");
            System.Console.WriteLine($"z = {Math.Pow(x, 3) / 3 + Math.Cos(Math.Pow(x + b, 3))}");
            System.Console.WriteLine();

            Console.WriteLine("Задание 2");
            Console.WriteLine("Пределы интегрирования:");
            Console.WriteLine("Введите а");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень n");
            int n = int.Parse(Console.ReadLine());
            for (double i = a; i < b; i += 0.1)
            {
                Console.WriteLine($"Результат при i = {Math.Round(i, 1)}: {Integral(n, a, i)}");
            }
            Console.ReadKey();
        }
    }
}
