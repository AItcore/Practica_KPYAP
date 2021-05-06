using System;
using System.Collections.Generic;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            System.Console.Write("Введите первое число:");
            List<DecimalString> decimalString = new List<DecimalString>(3);
            decimalString.Add(new DecimalString(int.Parse(Console.ReadLine())));
            System.Console.Write("Введите второе число:");
            decimalString.Add(new DecimalString(int.Parse(Console.ReadLine())));
            System.Console.WriteLine("Разность: " + (decimalString[0]-decimalString[1]));
            System.Console.WriteLine("Первое число больше втрого? " + (decimalString[0] > decimalString[1]));
            System.Console.WriteLine("Первое число меньше втрого? " + (decimalString[0] < decimalString[1]));

            Console.WriteLine("Задание №2");
            Console.Write("Количество рейсов: ");
            int n = int.Parse(Console.ReadLine());
            List<Aeroflot> flot = new List<Aeroflot>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Пункт назначения: ");
                string point = Console.ReadLine();
                Console.Write("Номер рейса: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Тип самолёта: ");
                string typeP = Console.ReadLine();
                flot.Add(new Aeroflot(point, number, typeP));
            }
            flot.Sort();
            Console.WriteLine("Отсортированны массив самолётов");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(flot[i].ToString());
            }
            bool flag = false;
            System.Console.WriteLine("Введите тип самолёта: ");
            string type = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (flot[i].PlaneType == type)
                {
                    System.Console.WriteLine(flot[i].ToString());
                    flag = true;
                }
            }
            if (!flag)
            {
                System.Console.WriteLine("Таких самолётов нету");
            }
            Console.ReadKey();
        }
    }
}
