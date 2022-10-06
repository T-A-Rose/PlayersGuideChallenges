using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    internal class MainClass : Robot
    {
        static public void Main(String[] args)
        {
            Robot robot = new();

            Console.WriteLine("Hello adventurer, please enter a command for the robot to execute!");
            Console.WriteLine("The options are as follows: Power on, Power off, North, East, South & West");

            for (int i = 0; i < robot.Commands.Length; i++)
            {
                string userInput = Console.ReadLine().ToLower();
                robot.Commands[i] = userInput switch
                {
                    "power on" => new OnCommand(),
                    "power off" => new OffCommand(),
                    "north" => new NorthCommand(),
                    "east" => new EastCommand(),
                    "south" => new SouthCommand(),
                    "west" => new WestCommand(),
                    _ => throw new Exception()
                };
            }
            robot.Run();
            Console.ReadLine();
        }
    }
}
