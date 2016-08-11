using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Weapon
    {
        string name;
        int ammo;
       public Weapon (string name, int ammo) //input weapon name and ammo amount
        {
            this.name = name;
            this.ammo = ammo;
        }
        
        public int getStatus()
        {
            //maybe put a counter
            return ammo;
        }
      
    }
}
