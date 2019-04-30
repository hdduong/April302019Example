using System;
using April302019Example.Roll;
using April302019Example.Shout;

namespace April302019Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var kenFighter = new Ken(new MaleVoice(), new RollForward());
            kenFighter.Display();
            kenFighter.PerformRoll();

            var chunli = new Chunli(new FemaleVoice(), new RollNoWay());
            chunli.Display();
            chunli.PerformRoll();
        }
    }
}
