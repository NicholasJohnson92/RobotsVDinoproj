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
        List<string> weaponS = new List<string>();

        public string weaponType;

        public int atkpwr;
        int weaponDrain;
       
        
        
        //Constructor

        public Weapon( )
        {
            
            


        }


        //Member methods

        public void chooseWeapon()



        {
            Console.WriteLine(" Please Choose a Weapon (Axe, Sword, Lazer? ) ");
            weaponType = Console.ReadLine();
           
            switch (weaponType)
            {
                case "axe":
                case "Axe":
                    atkpwr = 120;
                    weaponDrain = 30;
                    Console.WriteLine(" Robot " + " Chose " + weaponType + " with an attack power of " + atkpwr);
                    break;
                case "Sword":
                case "sword":
                    atkpwr = 90;
                    weaponDrain = 15;
                    Console.WriteLine(" Robot " + " Chose " + weaponType + " with an attack power of " + atkpwr);
                    break;
                case "lazer":
                case "Lazer":
                case "Laser":
                case "laser":
                    atkpwr = 200;
                    weaponDrain = 70;
                    Console.WriteLine(" Robot " + " Chose " + weaponType + " with an attack power of " + atkpwr);
                    break;
                default:
                    atkpwr = 35;
                    weaponDrain = 3;
                    Console.WriteLine(" Oho!! This Robot chose to forgo weapons in favor of it's fists!! It will strike with a Attack power of " + atkpwr);
                    break;
            }
            

            Console.ReadLine();
            






            



        }


    }
}
