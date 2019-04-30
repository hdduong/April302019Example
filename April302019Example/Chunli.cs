using System;
using System.Collections.Generic;
using System.Text;

namespace April302019Example
{
    public class Chunli : Fighter
    {
        public Chunli(IShoutStyle shoutStyle, IRollStyle rollStyle)
        {
            ShoutStyle = shoutStyle;
            RollStyle = rollStyle;
        }
    }
}
