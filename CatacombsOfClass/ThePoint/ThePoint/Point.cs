using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePoint
{
    internal class Point
    {
        public int _x { get; set; }
        public int _y { get; set; }

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Point()
        {
            _x = 0;
            _y = 0;
        }    
    }
}
