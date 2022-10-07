using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    public class OnCommand : IRobotCommand
    {
        void IRobotCommand.Execute(Robot robot) => robot.IsPowered = true;

        public void Run(Robot robot) => robot.IsPowered = true;
    }
}
