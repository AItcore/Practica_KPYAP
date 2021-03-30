using System;

namespace _10
{
    class Program
    {
        delegate bool Operation(char symbol, string line);
        static void Main(string[] args)
        {
            Operation del = (symbol , line) => {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == symbol)
                    {
                        return true;
                    }
                }
                return false;
            };
            System.Console.WriteLine("Введите строку");
            string line = Console.ReadLine();
            System.Console.WriteLine("Введите символ который хотите найти в строке: ");
            char symbol = Console.ReadLine()[0];
            bool flag = del(symbol,line);
            if (flag)
            {
                System.Console.WriteLine("Символ есть в строке");
            }
            else
            {
                System.Console.WriteLine("Символа нету в строке");
            }
        }
    }
}
