using System;
using System.Collections.Generic;
using System.Text;

namespace April302019Example.Shout
{
    public class MaleVoice : IShoutStyle
    {
        public void Shout()
        {
            Console.WriteLine("Male voice");
        }
    }
}
