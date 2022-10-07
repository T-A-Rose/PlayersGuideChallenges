using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    internal class NorthCommand : IRobotCommand
    {
        void IRobotCommand.Execute(Robot robot) => robot.Y += 1;   
    }
}
