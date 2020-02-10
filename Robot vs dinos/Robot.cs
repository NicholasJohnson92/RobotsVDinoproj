using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_dinos
{
    class Robot
    {

        //Member Varabiables


        public string robotName;
       public int robotHealth;

       public int robotpwrLvl;


        public Weapon weapon;
        //Constructor

        public Robot() 
        {
            robotpwrLvl = 100;
            robotHealth = 100;
            




        }






        //Member methods

        public void ArmRobot() {
            Console.WriteLine(" Please Choose an alpha-numeric designation for this Robot ");
            robotName = Console.ReadLine().ToUpper();
            Console.WriteLine(" The Robot will now be referred to as :" + robotName);
            Console.WriteLine( " The current health of " + robotName + " is " + robotHealth + " and its current power reserve is: " + robotpwrLvl );
            weapon = new Weapon(robotName);
           
            
        
        
        
        }






















    }
}
