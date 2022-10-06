using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    public abstract class RobotCommand
    {
        public virtual void Run(Robot robot)
        {
            if (robot.IsPowered) Execute(robot);
        }

        protected abstract void Execute(Robot robot);
    }
}
