using System;
using System.Collections.Generic;
using System.Text;

namespace April302019Example
{

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string Display()
        {
            return $"(x:{X},y:{Y})";
        }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
        }
    }

    /*
    public class Point : IEquatable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string Display()
        {
            return $"(x:{X},y:{Y})";
        }

        public bool Equals(Point other)
        {
            if (other == null) return false;
            return X == other.X && Y == other.Y;
        }


        public override int GetHashCode()
        {
            return X.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Point point = (Point) obj;
            if (point != null)
            {
                return Equals(point);
            }
            else
            {
                return false;
            }
        }
    }
    */
}
