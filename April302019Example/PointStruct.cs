using System;
using System.Collections.Generic;
using System.Text;

namespace April302019Example
{
    public struct PointStruct
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
            return $"(x:{X}, y:{Y})";
        }
    }

    /*
     * Struct cannot inherit from other struct or class
     */
    /* 
    public struct ThreeDPointStrut : PointStruct
    {

    }
    */

    public struct ThreeDPointStrut : IThreeDInterface
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public ThreeDPointStrut(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public string Display()
        {
            return $"(x:{X}, y:{Y}), z:{Z}";
        }

        /*
        protected int GetX()
        {}
        */
    }
}
