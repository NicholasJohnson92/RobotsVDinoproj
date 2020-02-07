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
                    dinoStam = 150;
                    dinoattk = 50;
                    dinoFatigue = 25; break;


               
                
                case "trex":
                case "tyrannosaur":
                    dinoSpecies = " T-Rex ";
                    dinoHlth = 175;
                    dinoStam = 100;
                    dinoattk = 100;
                    dinoFatigue = 33;
                    break;
                case "tri-horn":
               
                case "trihorn":
                    dinoSpecies = " Triceratops ";
                    dinoHlth = 325;
                    dinoStam = 75;
                    dinoattk = 99;
                    dinoFatigue = 35;
                    break;
                default: Console.WriteLine(" Please Choose a Dinosaur from avaible types ( Raptor Tyrannosaur  Trihorn ) ");

                    pickaDino();
                    break;
                    
                    
                    





            }
        
        
        
        }





        




    }
}
