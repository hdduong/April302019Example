using System;

namespace April302019Example
{
    class Program
    {
        /*
        static void ChangeValue(ref int x)
        {
            x = 200;

            Console.WriteLine(x);
        }
        */

        static void Main(string[] args)
        {
            int i = 100;
          

            var p = new Point(3 ,4);
            var p2 = p;
            if (p2.Equals(p))
            {
                Console.WriteLine("p2.Equals(p)");
            }
           
            var p3 = new Point(3, 4);
            if (p3.Equals(p))
            {
                Console.WriteLine("p3.Equals(p)");
            }

            // box an unbox
            var ps = new PointStruct(3, 5);
            object o = ps; // boxing
            var ps2 = (PointStruct) o; // unboxing

            ps2.X = 6;
            Console.WriteLine(ps.Display());
            Console.WriteLine(ps2.Display());
           

            // deep and shallow
            p2.X = 5;
            Console.WriteLine(p.Display());
            Console.WriteLine(p2.Display());

            var p3d = new Point(p);
            p3d.X = 6;
            Console.WriteLine(p.Display());
            Console.WriteLine(p3d.Display());

            /*
            ChangeValue(ref i);
            Console.WriteLine(i);
            */
        }



    }


}
