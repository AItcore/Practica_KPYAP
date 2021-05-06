using System;

namespace _1
{
    class Program
    {
        static void ForCycle()
        {
            System.Console.WriteLine("Цикл For");
            for (double a = 1; a <= 3; a += 0.2)
            {
                System.Console.WriteLine((1 - Math.Pow(Math.Sin(a), 2)) / (1 + Math.Sin(a)));
            }
        }
        static void WhileCycle()
        {
            System.Console.WriteLine("Цикл While");
            double a = 1;
            while (a < 3)
            {
                System.Console.WriteLine((1 - Math.Pow(Math.Sin(a), 2)) / (1 + Math.Sin(a)));
                a += 0.2;
            }
        }
        static void DoWhileCycle()
        {
            System.Console.WriteLine("Цикл Do While");
            double a = 1;
            do
            {
                System.Console.WriteLine((1 - Math.Pow(Math.Sin(a), 2)) / (1 + Math.Sin(a)));
                a += 0.2;
            }
            while (a <= 3);
        }
        static void N2()
        {
            System.Console.WriteLine("Введите двузначное число: ");
            string a = Console.ReadLine();
            Random rnd = new Random();
            int b = rnd.Next(10, 100);
            if (int.Parse(a) > b)
            {
                System.Console.WriteLine($"Число {a} больше случайного числа {b} " + Math.Pow(int.Parse(a), 4));
            }
            else
            {
                System.Console.WriteLine($"Число {a} меньше случайного числа {b} " + int.Parse(a[0].ToString()) + int.Parse(a[1].ToString()));
            }
        }
        static void N3()
        {
            Random rnd = new Random();
            System.Console.WriteLine("Размер массива");
            int N = int.Parse(Console.ReadLine());
            int[,] arr = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr[i,j] = rnd.Next(-100,100);
                    Console.Write(arr[i,j] + " ");
                }
                System.Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += arr[i,i];
            }
            System.Console.WriteLine("Сумма главной диагонали: " + sum);
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Задание №1");
            ForCycle();
            WhileCycle();
            DoWhileCycle();
            System.Console.WriteLine("Задание №2");
            N2();
            System.Console.WriteLine("Задание №3");
            N3();
            Console.ReadKey();
        }
    }
}
