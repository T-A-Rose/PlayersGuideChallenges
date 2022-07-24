using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchtower
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello there adventurer!");
            Console.WriteLine("Please can you input co-ordinates for the enemies relative location, first an x co-ordinate and then 2nd a y co-ordinate?");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (x < 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("The enemy is to the Northwest!");
                } else if (y == 0)
                {
                    Console.WriteLine("The enemy is to the West!");
                } else
                {
                    Console.WriteLine("The enemy is to the Southwest!");
                }
            } else if (x == 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("The enemy is to the North!");
                }
                else if (y == 0)
                {
                    Console.WriteLine("The enemy is here, everyone to battlestations!!!");
                }
                else
                {
                    Console.WriteLine("The enemy is to the South!");
                }
            } else
            {
                if (y > 0)
                {
                    Console.WriteLine("The enemy is to the Northeast!");
                }
                else if (y == 0)
                {
                    Console.WriteLine("The enemy is to the East!");
                }
                else
                {
                    Console.WriteLine("The enemy is to the Southeast!");
                }
            }
            Console.ReadLine();

            string test = x < 0 ? "Well done" : "Idiot";

        }
    }
}
