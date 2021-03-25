using System;

namespace _9
{
    class PrecisionPrinter : IPrinter
    {
        private int n;
        public PrecisionPrinter(int n)
        {
            this.n = n;
        }
        public void Print(double number)
        {
            System.Console.Write(Math.Round(number, n)+"\t");
        }
    }
}
