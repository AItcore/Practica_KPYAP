namespace _9
{
    class LinePrinter : IPrinter
    {
        public int lineLength;
        public LinePrinter(int n)
        {
            this.lineLength = n;
        }
        public void Print(double number)
        {
            System.Console.Write(number);
            for (int i = 0; i < this.lineLength; i++)
            {
                System.Console.Write("-");
            }
        }
    }
}
