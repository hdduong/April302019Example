using System;
using System.Collections.Generic;
using System.Text;

namespace April302019Example.Roll
{
    public class RollNoWay : IRollStyle
    {
        public void Roll()
        {
            Console.WriteLine("Not rolling");
        }
    }
}
