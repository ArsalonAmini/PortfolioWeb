using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class SoliderRobot : Robot
    {
        public SoliderRobot (string name, string color) : base(name, color)
        {
        }

        Weapon Pistol = new Weapon("pistol", 10);

        public override void Talk()
        {
            base.Talk();
            Console.WriteLine("I'm a Solider Robot, its mow down time!");
        }

    }
}
