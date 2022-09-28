using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    internal class EastCommand : RobotCommand
    {
        protected override void Execute(Robot robot) => robot.X += 1;
    }
}
