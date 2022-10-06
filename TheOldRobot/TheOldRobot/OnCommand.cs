using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    public class OnCommand : RobotCommand
    {
        protected override void Execute(Robot robot) => robot.IsPowered = true;

        public override void Run(Robot robot) => robot.IsPowered = true;
    }
}
