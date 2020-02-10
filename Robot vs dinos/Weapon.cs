using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_dinos
{
    class Weapon
    {

        //Member Varawbiables
        List<Weapon> weapons;
        public string weaponType;

        public int atkpwr;
         public int weaponDrain;
       public string robotName;

        //public Robot robot = new Robot();
        
        //Constructor
        public Weapon(string name)
        {
            weapons = new List<Weapon>();
            robotName = name;
            ChooseWeapon();
        }


        //Member methods

        public void ChooseWeapon()
        {
            Console.WriteLine(" Please Choose a Weapon (Axe, Sword, Lazer? ) ");
            weaponType = Console.ReadLine().ToLower();
           
            switch (weaponType)
            {
                case "axe":
                
                    atkpwr = 96;
                    weaponDrain = 30;
                    Console.WriteLine(robotName + " Chose " + weaponType + " with an attack power of " + atkpwr + " and will cost " +weaponDrain+ " power to attack ."  );
                    break;
                
                case "sword":
                    atkpwr = 60;
                    weaponDrain = 15;
                    Console.WriteLine(robotName + " Chose " + weaponType + " with an attack power of " + atkpwr + " and will cost " + weaponDrain + " power to attack ."); break;
                case "lazer":
                
                
                case "laser":
                    atkpwr = 170;
                    weaponDrain = 40;
                    Console.WriteLine(robotName + " Chose " + weaponType + " with an attack power of " + atkpwr + " and will cost " + weaponDrain + " power to attack ."); break;
                default:
                    atkpwr = 35;
                    weaponDrain = 3;
                    Console.WriteLine(" Oho!! " + robotName + " chose to forgo weapons in favor of it's fists!! " +robotName +" will strike with a Attack power of " + atkpwr + " and will cost " + weaponDrain + " power to attack .");
                    break;
            }
            

            Console.ReadLine();
            






            



        }


    }
}
