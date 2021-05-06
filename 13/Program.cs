using System;
using System.IO;
using System.Linq;
namespace _13
{
    class Program
    {
        static void Binary(ref int[] arr, int key)
        {
            int L = 0, R = arr.Length - 1, mid;

            while (L <= R)
            {
                mid = (R + L) / 2;
                if (arr[mid] == key)
                {
                    int[] buf = new int[arr.Length - 1];
                    int count = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i != mid)
                        {
                            buf[count] = arr[i];
                            count++;
                        }
                    }
                    arr = buf;
                    System.Console.WriteLine("Элемент найден");
                    return;
                }
                else if (arr[mid] < key) { L = mid + 1; }
                else if (arr[mid] > key) { R = mid - 1; }
            }
            System.Console.WriteLine("Элемент не найден");
        }
        static void Main(string[] args)
        {
            string path = @"./Marks.txt";
            int[] marks = new int[5];
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < marks.Length; i++)
            {
                System.Console.WriteLine($"Введите оценку по экзамену №{i + 1}");
                marks[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(marks);
            Array.Reverse(marks);
            for (int i = 0; i < marks.Length; i++)
            {
                if (i != marks.Length - 1)
                {
                    sw.Write(marks[i] + " ");
                }
                else
                {
                    sw.Write(marks[i]);
                }
            }
            sw.Close();
            StreamReader sr = new StreamReader(path);
            path = @"./Marks2.txt";
            sw = new StreamWriter(path);
            string text = sr.ReadLine();
            System.Console.WriteLine(text);
            int[] arr = text.Split(" ").Select(s => Convert.ToInt32(s)).ToArray();
            Array.Reverse(arr);
            System.Console.WriteLine("Введите число которое надо удалить");
            int val = int.Parse(Console.ReadLine());
            Binary(ref arr, val);
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    sw.Write(arr[i] + " ");
                }
                else
                {
                    sw.Write(arr[i]);
                }
            }
            sw.Close();
            Console.ReadKey();
        }
    }
}
