using System;
using System.Collections.Generic;
using System.Text;

namespace April302019Example
{
    public class Ken : Fighter
    {
        public Ken(IShoutStyle shoutStyle, IRollStyle rollStyle)
        {
            ShoutStyle = shoutStyle;
            RollStyle = rollStyle;
        }
    }
}
