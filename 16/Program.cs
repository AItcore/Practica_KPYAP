using System;
using System.Text.RegularExpressions;


namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string patern = @"(\w+)(\s)(\w+)";
            text = Regex.Replace(text, patern ,@"$1, $3");
            System.Console.WriteLine(text);
        }
    }
}
