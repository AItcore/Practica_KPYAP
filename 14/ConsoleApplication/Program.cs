using System;
using ClassLibrary;
using MyLib2;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Задание №1");
            int[] arr = new int[10];
            Random rnd = new Random();
            System.Console.WriteLine("Набор случайных чисел");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
                Console.Write(arr[i] + " ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("\nСортировка по возростанию");
            MyClass.SortOrder(ref arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("\nСортировка по убыванию");
            MyClass.AnotherSortOrder(ref arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Задание №2");
            int[,] arr1 = new int[5, 5];
            // Random rnd = new Random();
            for (int i = 0; i < arr1.GetLength(1); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i, j] = rnd.Next(-100, 100);
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            System.Console.WriteLine();
            System.Console.WriteLine("\nСортировка по возростанию");
            Sorting.Asc(ref arr1);
            for (int i = 0; i < arr1.GetLength(1); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            System.Console.WriteLine();
            System.Console.WriteLine("\nСортировка по убыванию");
            Sorting.Desc(ref arr1);
            for (int i = 0; i < arr1.GetLength(1); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            System.Console.WriteLine();
        }
    }
}
