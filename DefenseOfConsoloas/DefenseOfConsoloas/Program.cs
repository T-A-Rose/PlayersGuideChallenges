using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseOfConsoloas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Defense of Consolas";


            Console.WriteLine("Please help, we need the co-ordinates on where to place the magical barrier! These need to be in rows and columns respectively!");
            Console.Write("First enter the row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("That's great, now enter the column: ");
            int column = Convert.ToInt32(Console.ReadLine());

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;     
            Console.WriteLine($"Deploy to: ({row},{column - 1})");
            Console.WriteLine($"Deploy to: ({row + 1},{column})");
            Console.WriteLine($"Deploy to: ({row},{column + 1})");
            Console.WriteLine($"Deploy to: ({row - 1},{column})");

            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello there:\t {name, 20}");
            //Console.WriteLine($"{Math.PI:0.000}");
            Console.Beep();
            Console.ReadLine();

        }
    }
}
