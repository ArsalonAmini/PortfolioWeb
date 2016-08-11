using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        //This is a parent class Rob/ot created by/
        //Arsalon N Amini-Hajibashi  8/11/2016
        static void Main(string[] args)
        {

           MartialArtRobot martialArt = new MartialArtRobot("adam");
           SoliderRobot soldier = new SoliderRobot("soldier", "blue");
            
            Battle battle = new Battle(martialArt, soldier);
            battle.runBattle();

            Console.WriteLine("Fights over!");
            Console.ReadLine();
        }    
    }
   
}
