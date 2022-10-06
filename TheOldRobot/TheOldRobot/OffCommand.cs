using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    public class OffCommand : RobotCommand
    {
        protected override void Execute(Robot robot) => robot.IsPowered = false;

    }
}
