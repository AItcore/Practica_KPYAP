using System;
using System.Linq;
using MyLib;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4 пары точек треугольника");
            double[,] arr = new double[4,2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                double[] temp = Console.ReadLine().Split().Select(double.Parse).ToArray();
                arr[i,0] = temp[0];
                arr[i,1] = temp[1]; 
            }
            Rhomb rhomb = new Rhomb(new Point(arr[0,0],arr[0,1]), new Point(arr[1,0],arr[1,1]), new Point(arr[2,0],arr[2,1]), new Point(arr[3,0],arr[3,1]));
            if (rhomb.Inhere(new Point(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()))))
            {
                System.Console.WriteLine("Точка в ромбе");
            }
            else
            {
                System.Console.WriteLine("Точка не в ромбе");
            }
        }
    }
}
