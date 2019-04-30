using System;
using System.Collections.Generic;
using System.Text;

namespace April302019Example.Shout
{
    public class FemaleVoice : IShoutStyle
    {
        public void Shout()
        {
            Console.WriteLine("Female voice");
        }
    }
}
