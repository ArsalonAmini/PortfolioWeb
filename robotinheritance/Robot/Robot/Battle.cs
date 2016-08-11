using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Battle
    {
        Robot robot;
        Robot robot2;

        public Battle (Robot robot, Robot robot2)
        {
            this.robot = robot;
            this.robot2 = robot2;
        }

        public void runBattle()
        {
            robot.Talk();
            robot.FireWeapon();
            robot2.Talk();
            robot2.FireWeapon();
        }

    }
}
