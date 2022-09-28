using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    internal class SouthCommand : RobotCommand
    {               
        protected override void Execute(Robot robot) => robot.Y -= 1;
    }
}
