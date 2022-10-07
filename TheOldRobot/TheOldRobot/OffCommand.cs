using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    public class OffCommand : IRobotCommand
    {
        void IRobotCommand.Execute(Robot robot) => robot.IsPowered = false;

    }
}
