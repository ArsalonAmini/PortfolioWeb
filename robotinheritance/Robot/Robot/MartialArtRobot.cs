using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class MartialArtRobot : Robot
    {
        public MartialArtRobot(string name) : base(name,"color") {
        }

        public Weapon Sword = new Weapon("Sword", 10);

        public override void Talk()
        {
         
            Console.WriteLine("I'm a Martial Artist who will not take it easy on you!");
        }

    }
}
