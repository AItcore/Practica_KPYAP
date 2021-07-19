using System;

namespace MyLib
{
    public class Point
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
    public class Rhomb
    {
        private Point point1;
        private Point point2;
        private Point point3;
        private Point point4;

        public Rhomb(Point point1, Point point2, Point point3, Point point4)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
        }
        public bool Inhere(Point point)
        {
            if ((SidePoint(point1,point2, point) && SidePoint(point2, point3, point) && SidePoint(point3,point4, point) && SidePoint(point4, point1, point)) || (!SidePoint(point1, point2, point) && !SidePoint(point2, point3, point) && !SidePoint(point3, point4, point) && !SidePoint(point4, point1, point)))
            {
                return true;
            }
            return false;
        }
        private bool SidePoint(Point A,Point B, Point point)
        {
            double x1 = B.X - A.X;
            double x2 = point.X - A.X;
            double y1 = B.Y - A.Y;
            double y2 = point.Y - A.Y;
            if (x1*y2 - x2*y1 >= 0)
            {
                return true;
            }  
            else
            {
                return false;
            }
        }
        public Point Point1 { get => point1; set => point1 = value; }
        public Point Point2 { get => point2; set => point2 = value; }
        public Point Point3 { get => point3; set => point3 = value; }
        public Point Point4 { get => point4; set => point4 = value; }
    }
}
