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

            int inputInstructions = 0;
            while (inputInstructions < 3)
            {
                string userInput = Console.ReadLine();
                var isValid = userInput switch
                {
                    "Power on" => new OnCommand(),
                    "Power off" => new OffCommand(),
                    "North" => new NorthCommand(),
                    "East" => new EastCommand(),
                    "South" => new SouthCommand(),
                    "West" => new WestCommand(),
                    _ => throw new Exception()
                };
                inputInstructions++;
            }
        }
    }
}
