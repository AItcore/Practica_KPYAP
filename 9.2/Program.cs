using System;

namespace _9._2
{
    class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
    }
    class ColoredPoint : Point
    {
        private string color;

        public ColoredPoint(double x, double y, string color) : base(x, y)
        {
            this.Color = color;
        }

        public string Color { get => color; set => color = value; }
    }
    class Line : Point
    {
        private Point pt1;
        private Point pt2;

        public Point Pt1 { get => pt1; set => pt1 = value; }
        public Point Pt2 { get => pt2; set => pt2 = value; }

        public Line(double x1, double y1, double x2, double y2) : base(0, 0)
        {
            Pt1 = new Point(x1, y1);
            Pt2 = new Point(x2, y2);
        }
        public void TurnLine(double angle, Point pt)
        {
            angle = angle * Math.PI / 180;
            double x1 = (pt1.X - pt.X) * Math.Cos(angle) - (pt1.Y - pt.Y) * Math.Sin(angle) + pt.X;
            double y1 = (pt1.X - pt.X) * Math.Sin(angle) - (pt1.Y - pt.Y) * Math.Cos(angle) + pt.Y;
            double x2 = (pt2.X - pt.X) * Math.Cos(angle) - (pt2.Y - pt.Y) * Math.Sin(angle) + pt.X;
            double y2 = (pt2.X - pt.X) * Math.Sin(angle) - (pt2.Y - pt.Y) * Math.Cos(angle) + pt.Y;

            this.pt1 = new Point(x1, y1);
            this.pt2 = new Point(x2, y2);
        }
        public override string ToString()
        {
            return $"X1: {Pt1.X} Y1: {Pt1.Y}\nX2: {Pt2.X} Y2: {Pt2.Y}\n";
        }
    }
    class ColoredLine : Line
    {
        private string color;
        public ColoredLine(double x1, double y1, double x2, double y2, string color) : base(x1, y1, x2, y2)
        {
            this.Color = color;
        }
        public string Color { get => color; set => color = value; }
    }
    class PolyLine : Line
    {
        protected Line[] lines;

        public PolyLine(Line[] lines) : base(0, 0, 0, 0)
        {
            this.lines = lines;
        }
        public void MultiLine(double cof)
        {
            for (int i = 0; i < this.lines.Length; i++)
            {
                this.lines[i].Pt2.X = cof * this.lines[i].Pt2.X;
                this.lines[i].Pt1.X = cof * this.lines[i].Pt1.X;
                this.lines[i].Pt2.Y = cof * this.lines[i].Pt2.Y;
                this.lines[i].Pt1.Y = cof * this.lines[i].Pt1.Y;
            }
        }
        public override string ToString()
        {
            string text = "";
            for (int i = 0; i < this.lines.Length; i++)
            {
                text += lines[i].ToString() + "\n";
            }
            return text;
        }
    }
    interface ICalculation
    {
        double Perform(double x);
    }
    class Add : ICalculation
    {
        private double num;

        public Add(double num)
        {
            this.num = num;
        }
        public double Perform(double x)
        {
            return x + num;
        }
    }
    class Multiply : ICalculation
    {
        private double cof;
        public Multiply(double num)
        {
            this.cof = num;
        }
        public double Perform(double x)
        {
            return this.cof * x;
        }
    }
    class Program
    {
        static double Calculate(double x, Add add, Multiply mul)
        {
            x = add.Perform(x);
            x = mul.Perform(x);
            return x;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Задание №1");
            Line line = new Line(1, 1, 2, 2);
            line.TurnLine(60, new Point(1, 2));
            System.Console.WriteLine(line.ToString());
            Line[] lines = new Line[3];
            lines[0] = new Line(1, 1, 3, 3);
            lines[1] = new Line(1, 1, 1, 3);
            lines[2] = new Line(1, 3, 3, 3);
            PolyLine pl = new PolyLine(lines);
            System.Console.WriteLine(pl.ToString());
            pl.MultiLine(2);
            System.Console.WriteLine("Увеличен в 2 раза");
            System.Console.WriteLine(pl.ToString());
            
            System.Console.WriteLine("Задание №2");
            System.Console.WriteLine(Calculate(10, new Add(4), new Multiply(10)));
        }
    }
}
