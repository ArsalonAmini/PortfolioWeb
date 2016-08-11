using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Robot
    {      
        public string name;
        public string color;
        string userInput;
    
       
        //actions (fire weapon (weapon, robot), talkSmack, retreat, advance)
        //methods (lose health)

        public Robot (string name, string color) //constructor
        {
            this.name = name;
            this.color = color;
        }

        public virtual void Talk()  //method #1 for talking
        {
            Console.WriteLine("You, have no idea who you are messing with?");
        }
        public virtual void FireWeapon() //fire weapon method
        {
            Console.WriteLine("-------pew---- pew----------?");
        }
          
      }

 }

