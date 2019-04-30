using System;
using System.Collections.Generic;
using System.Text;

namespace April302019Example
{
    public abstract class Fighter
    {
        public IShoutStyle ShoutStyle { get; set; }
        public IRollStyle RollStyle { get; set; }

        public void Display()
        {
            Console.WriteLine(this.GetType());
        }

        public void Kick()
        {
            Console.WriteLine("Perform Kick");
        }

        public void Punch()
        {
            Console.WriteLine("Peform Punch");
        }

        public void PerformRoll()
        {
            RollStyle.Roll();
        }

        public void PerformShout()
        {
            ShoutStyle.Shout();
        }
    }
}
