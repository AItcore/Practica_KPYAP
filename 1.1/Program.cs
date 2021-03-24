using System;

namespace _1
{
    class Program
    {
        static void ForCycle()
        {
            Console.WriteLine("Цикл For");
            for (double a = 1; a <= 3; a += 0.2)
            {
                Console.WriteLine($"z = {(Math.Sin(a * 4) / (1 + Math.Cos(4 * a))) * (Math.Cos(2 * a) / (1 + Math.Cos(2 * a)))}");
            }
        }
        static void WhileCycle()
        {
            Console.WriteLine("Цикл While");
            double a = 1;
            while (a < 3)
            {
                Console.WriteLine($"z = {(Math.Sin(a * 4) / (1 + Math.Cos(4 * a))) * (Math.Cos(2 * a) / (1 + Math.Cos(2 * a)))}");
                a += 0.2;
            }
        }
        static void DoWhileCycle()
        {
            Console.WriteLine("Цикл Do While");
            double a = 1;
            do
            {
                System.Console.WriteLine($"z = {(Math.Sin(a * 4) / (1 + Math.Cos(4 * a))) * (Math.Cos(2 * a) / (1 + Math.Cos(2 * a)))}");
                a += 0.2;
            }
            while (a <= 3);
        }
        static void N2()
        {
            Random rnd = new Random();
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-5, 13);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int poloz = 0;
            int otriz = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    poloz++;
                }
                else
                {
                    otriz++;
                }
            }
            Console.WriteLine(poloz > otriz ? "Положительных чисел больше" : "Отрицательных чисел больше");
        }
        static void N3()
        {
            Random rnd = new Random();
            Console.WriteLine("Размер массива: ");
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = rnd.Next(100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                if (arr[i] % 4 == 0)
                    sum += arr[i];
            }
            Console.WriteLine("Сумма числе кратных 4: " + sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            ForCycle();
            WhileCycle();
            DoWhileCycle();
            Console.WriteLine("Задание №2");
            N2();
            Console.WriteLine("Задание №3");
            N3();
        }
    }
}
