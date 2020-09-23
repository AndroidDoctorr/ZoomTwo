using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenApp.Data
{

    // ENUMS


    public enum ThingyType { Normal = 1, Weird, Huge, Tiny };
    public class Thingy
    {
        public string OneThing { get; set; }
        public int OtherThing { get; set; }

        public ThingyType Type { get; set; }

        public Thingy() { }

        public Thingy(string oneThing)
        {
            OneThing = oneThing;
        }

        public Thingy(int otherThing)
        {
            OtherThing = otherThing;
        }

        public Thingy(string oneThing, int otherThing)
        {
            OneThing = oneThing;
            OtherThing = otherThing;
        }

        public Thingy(int otherThing, string oneThing)
        {
            OneThing = oneThing;
            OtherThing = otherThing;
        }

        public Thingy(ThingyType type)
        {
            Type = type;
        }
    }
















    public class ComplexThingy : Thingy
    {
        public string Mood { get; set; }
    }
}
