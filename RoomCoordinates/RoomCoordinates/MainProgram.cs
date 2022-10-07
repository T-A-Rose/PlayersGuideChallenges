using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCoordinates
{
    internal class MainProgram
    {

        static public void Main(String[] args)
        {
            Random random = new Random();

            Coordinate a = new Coordinate(1, 2);
            Coordinate b = new Coordinate(2, 3);
            Coordinate c = new Coordinate(3, 4);

            Console.WriteLine(Coordinate.adjacent(a, b));
            Console.WriteLine(Coordinate.adjacent(b, c));
            Console.WriteLine(Coordinate.adjacent(a, c));
            
            
            Console.ReadLine();
        }
    }
}
