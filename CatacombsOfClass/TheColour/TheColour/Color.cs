using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheColour
{
    internal class Color
    {

        public int RedValue { get; set; }
        public int GreenValue { get; set; }
        public int BlueValue { get; set; }

        public Color(int r, int g, int b)
        {
            RedValue = r;
            GreenValue = g;
            BlueValue = b;
        }

        public static Color White() => new Color(255, 255, 255);

        public static Color Black() => new Color(0, 0, 0);

        public static Color Red() => new Color(255, 0, 0);

        public static Color Orange() => new Color(255, 165, 0);

        public static Color Yellow() => new Color(255, 255, 0);

        public static Color Green() => new Color(0, 128, 0);

        public static Color Blue() => new Color(0, 0, 255);
  
        public static Color Purple() => new Color(128, 0, 128);

    }
}
