using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            System.Console.Write("Введите первое число:");
            DecimalString decimalString = new DecimalString(int.Parse(Console.ReadLine()));
            System.Console.Write("Введите второе число:");
            DecimalString decimalString2 = new DecimalString(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Разность: " + (decimalString-decimalString2));
            System.Console.WriteLine("Первое число больше втрого? " + (decimalString > decimalString2));
            System.Console.WriteLine("Первое число меньше втрого? " + (decimalString < decimalString2));
            Console.WriteLine("Задание №2");
            Console.Write("Количество рейсов: ");
            Aeroflot[] flot = new Aeroflot[int.Parse(Console.ReadLine())];
            for (int i = 0; i < flot.Length; i++)
            {
                Console.Write("Пункт назначения: ");
                string point = Console.ReadLine();
                Console.Write("Номер рейса: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Тип самолёта: ");
                string typeP = Console.ReadLine();
                flot[i] = new Aeroflot(point, number, typeP);
            }
            Array.Sort(flot);
            Console.WriteLine("Отсортированны массив самолётов");
            for (int i = 0; i < flot.Length; i++)
            {
                Console.WriteLine(flot[i].ToString());
            }
            bool flag = false;
            System.Console.WriteLine("Введите тип самолёта: ");
            string type = Console.ReadLine();
            for (int i = 0; i < flot.Length; i++)
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
        }
    }
}
