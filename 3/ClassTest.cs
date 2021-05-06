using System;

namespace _3
{
    class ClassTest
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите число: ");
            System.Console.WriteLine(ClassLibrary.Progres(int.Parse(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
