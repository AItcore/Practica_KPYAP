using System;
using System.IO;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Задание №1");
            string path = @"/home/kirill/coding/python/Practica_KPYAP/7/file.txt";
            StreamReader reader = new StreamReader(path);
            string[] text = reader.ReadToEnd().Split('\n');
            System.Console.WriteLine("Содержимое файла:");
            for (int i = 0; i < text.Length; i++)
            {
                System.Console.WriteLine(text[i]);
            }
            System.Console.WriteLine('\n');
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].IndexOf('?')!= -1)
                System.Console.WriteLine(text[i]);
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].IndexOf('!')!= -1)
                System.Console.WriteLine(text[i]);
            }
            System.Console.WriteLine("Задание №2");
            System.Console.WriteLine("Введите текст");
            text = Console.ReadLine().Split();
            int min = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[min].Length > text[i].Length)
                {
                    min = i;
                }
            }
            System.Console.WriteLine($"Порядковый номер слова с минимальной длиной {min+1}\nСимволов: {text[min].Length}\nСлово: {text[min]}");
            Console.ReadKey();
        }
    }
}
