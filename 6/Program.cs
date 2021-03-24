using System;
using System.Collections.Generic;
using System.Linq;
// Ввести массив А из 10 элементов, найти произведение элементов, 
// больших 8 и меньших 18 и кратных 10, 
// их количество и вывести результаты на экран.
namespace _6
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("Задание №1");
            int[] arr = new int[10];
            Random rnd = new Random();
            Console.WriteLine("Массив случайных чисел: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(20);
                Console.Write(arr[i] + " ");
            }
            int proiz = 1;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 8 && arr[i] < 18 && arr[i] % 10 == 0)
                {
                    proiz *= arr[i];
                    count++;
                }
            }
            Console.WriteLine($"\nКоличество чисел больших 8 и меньших 18 и кратных 10: {count}\nИх произведение: {proiz}");
        }
        static void Task2()
        {
            Console.WriteLine("Задание №2");
            Console.WriteLine("Введите длину массива: ");
            double[] arr = new double[int.Parse(Console.ReadLine())];
            Random rnd = new Random();
            Console.WriteLine("Массив случайных чисел: ");
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Math.Round(rnd.NextDouble() * rnd.Next(-100, 100), 2);
                Console.Write(arr[i] + " ");
                if (arr[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"\nКоличество отрицательных элементов: {count}");
            double sum = 0;
            for (int i = minElem(arr) + 1; i < arr.Length; i++)
            {
                sum += Math.Abs(arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = Math.Round(Math.Pow(arr[i], 2), 2);
                }
            }
            Console.WriteLine($"Сумма модулей элементов массива, расположенных после минимального по модулю элемента: {sum}");
            Array.Sort(arr);
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static int minElem(double[] arr)
        {
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) < Math.Abs(arr[min]))
                {
                    min = i;
                }
            }
            return min;
        }
        static void Task3()
        {
            System.Console.WriteLine("Задание №3-4");
            Console.WriteLine("Введите количество строк:"); 
            int n = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Введите количество столбцов:"); 
            int m = int.Parse(Console.ReadLine()); 
            Random rnd = new Random(); 
            int[,] matrix = new int[n, m]; 
            List<int> t = new List<int>(m); 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)  
                {
                    matrix[i, j] = rnd.Next(-5, 50);
                    Console.Write("{0} ", matrix[i, j]); 
                }
                Console.WriteLine(); 
            }
 
            Console.WriteLine("\n");
 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) t.Add(matrix[i, j]); 
                t = t.OrderBy(x => x).ToList(); 
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = t[j];
                    Console.Write("{0} ", matrix[i, j]); 
                }
                t.Clear(); 
                Console.WriteLine(); 
            }
 
            Console.WriteLine();
 
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++) if (matrix[j, i] >= 0) count++;
                if (count == n) 
                {
                    Console.WriteLine("номер первого столбца, где нет отрицательных элементов {0}", ++i);
                    break;
                }
                count = 0;
            }
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
    }
}
