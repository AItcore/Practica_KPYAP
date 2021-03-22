using System;

namespace _4
{
    class MyData
    {
        private int year;
        private int month;
        private int day;

        public MyData(int day, int month, int year)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }

        public int Year { get => year; set => year = value >= 0 ? value : throw new Exception("Invalid ti chto vve`"); }
        public int Month { get => month; set => month = value <= 12 && value >= 1 ? value : throw new Exception("Invalid ti chto vve`"); }
        public int Day { get => day; set => day = value <= 30 && value >= 1 ? value : throw new Exception("Invalid ti chto vve`l"); }
        public void Add(int day, int month, int year)
        {
            if (day < 0)
                throw new Exception("Invalid ti chto vve`");
            if (month < 0)
                throw new Exception("Invalid ti chto vve`");
            if (year < 0)
                throw new Exception("Invalid ti chto vve`");
            if (this.day + day < 31 && day > 0)
            {
                this.Day += day;
                day = 0;
            }
            else
            {
                month += (this.Day + day)/ 30;
                this.Day = (this.day + day) % 30;
                if (this.month + month <= 12 && month > 0)
                {
                    this.Month += month;
                    month = 0;
                }
                else
                {
                    year += (this.Month + month) / 12;
                    this.Month = (this.month + month) % 12;
                    this.Year += year;
                    year = 0;
                }
            }
            if (this.month + month <= 12 && month > 0)
            {
                this.Month += month;
                month = 0;
            }
            else
            {
                year += (this.Month + month) / 12;
                this.Month = (this.month + month) % 12;
                this.Year += year;
                year = 0;

            }
            this.Year += year;
        }
        public void Show()
        {
            System.Console.WriteLine($"{this.day}.{this.month}.{this.year}");
        }
    }
}