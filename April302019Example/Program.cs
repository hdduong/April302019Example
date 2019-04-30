using System;

namespace April302019Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new int();
            Console.WriteLine(i);

            var i2 = 3;
            Console.WriteLine(i2);

            var p = new PointStruct();
            Console.WriteLine(p.Display());
           

            var p1 = new PointStruct(3, 4);
            Console.WriteLine(p1.Display());
        }
    }
}
