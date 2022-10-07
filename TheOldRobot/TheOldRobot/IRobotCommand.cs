using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    public interface IRobotCommand
    {
        void Run(Robot robot)
        {
            if (robot.IsPowered) Execute(robot);
        }

        protected abstract void Execute(Robot robot);
    }
}
