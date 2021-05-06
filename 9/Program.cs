using System;

namespace _9
{
    class Program
    {
        static void PrintNumbers(double number, double step, LinePrinter Printer)
        {
            for (double i = 0; i < number; i += step)
            {
                Printer.Print(i);
            }
        }
        static void PrintNumbers(double number, double step, PrecisionPrinter Printer)
        {
            for (double i = 0; i < number; i += step)
            {
                Printer.Print(i);
            }
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Задание №1");
            System.Console.WriteLine("Введите первое двоичное число");
            ByteString text = new ByteString(Console.ReadLine());
            System.Console.WriteLine("Введите второе двоичное число");
            ByteString text2 = new ByteString(Console.ReadLine());

            System.Console.WriteLine("Сумма: " + (text + text2).Text);
            System.Console.WriteLine("Сравнение: " + (text == text2).ToString());
            text.ChangeZnak();
            System.Console.WriteLine("Противоположный знак первого числа: " + text.Text);

            System.Console.WriteLine("Задание №2");
            System.Console.WriteLine("Пример работы класса LinePrinter");
            LinePrinter line = new LinePrinter(6);
            line.Print(4.4);
            System.Console.WriteLine("\nПример работы класса PrecisionPrinter");
            PrecisionPrinter print = new PrecisionPrinter(2);
            print.Print(5.353264);
            System.Console.WriteLine("\nПример работы метода PrintNumbers с классом PrecisionPrinter");
            PrintNumbers(10.5, 0.2, new PrecisionPrinter(1));
            System.Console.WriteLine("\nПример работы метода PrintNumbers с классом LinePrinter");
            PrintNumbers(10.5, 0.2, new LinePrinter(3));

            System.Console.WriteLine("\nЗадание №3");
            MyTrigger trigger = new MyTrigger("T");
            System.Console.WriteLine("Пример работы ");
            trigger.input(0);
            trigger.input(1);
            trigger.input(0);
            trigger.input(1);
            Console.ReadKey();
        }
    }
}
