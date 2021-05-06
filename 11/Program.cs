using System;
using System.Threading;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(delegate() {startThread();});
            th1.Name = "1";
            Thread th2 = new Thread(delegate() {startThread();});
            th2.Name = "2";
            th2.Priority--;
            Thread th3 = new Thread(delegate() {startThread();});
            th3.Name = "3";
            th3.Priority++;

            System.Console.WriteLine($"Поток №{th3.Name} с приоритетом: {th3.Priority}");
            System.Console.WriteLine($"Поток №{th1.Name} с приоритетом: {th1.Priority}");
            System.Console.WriteLine($"Поток №{th2.Name} с приоритетом: {th2.Priority}");
            
            th1.Start();
            th2.Start();
            th3.Start();

            th1.Join();
            th2.Join();
            th3.Join();
            Console.ReadKey();
        }
        static void startThread()
        {
            System.Console.WriteLine($"Поток создан №{Thread.CurrentThread.Name}");
            System.Console.WriteLine($"Порядковый номер: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
