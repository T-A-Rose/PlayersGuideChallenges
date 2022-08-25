using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheColour
{
    internal class Color
    {

        public int RedValue { get; }
        public int GreenValue { get; }
        public int BlueValue { get; }

        public Color(int r, int g, int b)
        {
            RedValue = r;
            GreenValue = g;
            BlueValue = b;
        }

        public static Color White { get; } = new(255, 255, 255);

        public static Color Black { get; } = new(0, 0, 0);

        public static Color Red { get; } = new(255, 0, 0);

        public static Color Orange { get; } = new(255, 165, 0);

        public static Color Yellow { get; } = new(255, 255, 0);

        public static Color Green { get; } = new(0, 128, 0);

        public static Color Blue { get; } = new(0, 0, 255);
  
        public static Color Purple { get; } = new(128, 0, 128);
    }
}
