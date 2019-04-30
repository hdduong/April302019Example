using System;
using System.Collections.Generic;
using System.Text;

namespace April302019Example
{
    public class ThreeDPointClass : PointClass
    {
        public int Z { get; set; }

        public ThreeDPointClass(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public new string Display()
        {
            return $"(x:{X}, y:{Y}), z:{Z}";
        }

    }
}
