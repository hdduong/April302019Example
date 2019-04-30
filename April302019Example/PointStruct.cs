using System;
using System.Collections.Generic;
using System.Text;

namespace April302019Example
{
    public class PointStruct
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointStruct(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string Display()
        {
            return $"(x:{X},y:{Y})";
        }
    }
}
