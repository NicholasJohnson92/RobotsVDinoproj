using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_dinos
{
    class Dino
    {
        //Member Varabiables
        public string dinoSpecies;
        public int dinoHlth;
        public int dinoStam;
        public int dinoattk;
        public int dinoFatigue;

        public string dinonm;

        //Constructor

        public Dino ()
            {



                 }


        //Member methods
        public void pickaDino() {

            Console.WriteLine(" Choose a Species of dinosaur : ( Raptor Tyrannosaur  Trihorn ) ");
            dinoSpecies = Console.ReadLine().ToLower();
            switch(dinoSpecies)
            {
                case "raptor":

                    
                    dinoSpecies = " Velociraptor ";
                    dinoHlth = 85;
                    dinoStam = 100;
                    dinoattk = 50;
                    dinoFatigue = 15;
                    Console.WriteLine(" You have selected "  + dinoSpecies);
                    Console.WriteLine( " Health: " + dinoHlth);
                    Console.WriteLine(" Stamina : " + dinoStam);
                    Console.WriteLine( " Attack Power: " + dinoattk);
                    Console.WriteLine(" Attack Cost: " + dinoFatigue);
                    
                    Console.WriteLine(" Please choose a name for this Dinosaur  ");
                    dinonm = Console.ReadLine().ToUpper();
                    Console.WriteLine(" THis Dinosaur's name is now : " + dinonm);
                    break;


               
                
                case "trex":
                case "tyrannosaur":
                    dinoSpecies = " T-Rex ";
                    dinoHlth = 175;
                    dinoStam = 100;
                    dinoattk = 100;
                    dinoFatigue = 33;
                    Console.WriteLine(" You have selected " + dinoSpecies);
                    Console.WriteLine(" Health: " + dinoHlth);
                    Console.WriteLine(" Stamina : " + dinoStam);
                    Console.WriteLine(" Attack Power: " + dinoattk);
                    Console.WriteLine(" Attack Cost: " + dinoFatigue);
                    
                    
                    Console.WriteLine(" Please choose a name for this Dinosaur  ");
                    dinonm = Console.ReadLine().ToUpper();
                    Console.WriteLine(" THis Dinosaur's name is now : " + dinonm);
                    break;
                case "tri-horn":
               
                case "trihorn":
                    dinoSpecies = " Triceratops ";
                    dinoHlth = 325;
                    dinoStam = 100;
                    dinoattk = 99;
                    dinoFatigue =45;
                    Console.WriteLine(" You have selected " + dinoSpecies);
                    Console.WriteLine(" Health: " + dinoHlth);
                    Console.WriteLine(" Stamina : " + dinoStam);
                    Console.WriteLine(" Attack Power: " + dinoattk);
                    Console.WriteLine(" Attack Cost: " + dinoFatigue);
                    
                    Console.WriteLine(" Please choose a name for this Dinosaur  ");
                    dinonm = Console.ReadLine().ToUpper();
                    Console.WriteLine(" THis Dinosaur's name is now : " + dinonm);
                    break;
                default: Console.WriteLine(" Please Choose a Dinosaur from avaible types ( Raptor Tyrannosaur  Trihorn ) ");

                    pickaDino();
                    break;
                    
                    
                    





            }
        
        
        
        }





        




    }
}
