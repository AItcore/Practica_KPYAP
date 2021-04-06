using System;

namespace _15
{
    struct Aeroflot: IComparable
    {
        private string nextPoint;
        private int raceNumber;
        private string planeType;

        public Aeroflot(string point, int number, string plane)
        {
            this.nextPoint = point;
            this.raceNumber = number;
            this.planeType = plane;
        }

        public string PlaneType { get => planeType; set => planeType = value; }
        public string NextPoint { get => nextPoint; set => nextPoint = value; }
        public int RaceNumber { get => raceNumber; set => raceNumber = value; }

        public int CompareTo(object obj)
        {
            Aeroflot otherProduct = (Aeroflot)obj;
            return NextPoint.CompareTo(otherProduct.NextPoint);
        }
        public override string ToString()
        {
            return $"Пункт Назначения: {this.NextPoint}\nНомер рейса: {this.RaceNumber}\nТип самолёта: {this.PlaneType}";
        }
    }
}