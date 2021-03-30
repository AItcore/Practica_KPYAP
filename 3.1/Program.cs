using System;
using System.Text;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите слово: ");
            StringBuilder newLine = new StringBuilder(Console.ReadLine());
            if (ClassLibrary.Palindrom(newLine.ToString()))
            {
                System.Console.WriteLine("Слово палиндром");
                for (int i = newLine.Length-1; i >= 0 ; i--)
                {
                    if (i % 2 == 1)
                    {
                        newLine = newLine.Remove(i,1);
                    }
                }
            }
            else
            {
                System.Console.WriteLine("Слово не палиндром");
                for (int i = newLine.Length-1; i >= 0 ; i--)
                {
                    if (i % 2 == 0)
                    {
                        newLine = newLine.Remove(i,1);
                    }
                }
            }
            System.Console.WriteLine($"Результат работы программы: {newLine}");
        }
    }
}
