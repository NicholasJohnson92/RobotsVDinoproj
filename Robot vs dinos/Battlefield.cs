using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_dinos
{
    class Battlefield
    {

        //Member Varabiables
        public Herd herd1;




        Fleet fleet1;
        public int winCntrR = 0;
        public int winCntrd = 0;
        public string atkComnd;
        public int healthLeft1 ;
        public int healthLeft2;
        public int healthLeft3;

        public int robothealthLeft1;
        public int robothealthLeft2;
        public int robothealthLeft3;
        //Constructor
        public Battlefield() 
        {
            fleet1 = new Fleet();
            herd1 = new Herd();
            healthLeft1 = herd1.dino1.dinoHlth;
                healthLeft2 = herd1.dino2.dinoHlth;
            healthLeft3 = herd1.dino3.dinoHlth;
            robothealthLeft1 = fleet1.robot1.robotHealth;
            robothealthLeft2 = fleet1.robot2.robotHealth;
            robothealthLeft3 = fleet1.robot3.robotHealth;

            AttackRun();
           // WinCounter();



        }

        //Member methods

        public void AttackRun()
        {
            Console.WriteLine(" The robots approach a small clearing. " + " A Trio of " + herd1.dino1.dinoSpecies + ", " + herd1.dino2.dinoSpecies + ", " + herd1.dino3.dinoSpecies + " have appeared. Will Robot Command send the attach order??  ");

            Console.WriteLine(" The enemy is in sight, would you like to attack? (yes,no) ");
            atkComnd = Console.ReadLine().ToLower();

            switch (atkComnd)
            {
                case "yes":



                    if (herd1.dino1.dinoHlth <= 0 && herd1.dino2.dinoHlth <= 0 && herd1.dino3.dinoHlth <= 0)
                    {
                        Console.WriteLine(" Technology has Prevailed agasint the wilderness!! " + fleet1.robot1.robotName + ", " + fleet1.robot2.robotName + ", " + fleet1.robot3.robotName + " are victorious!! ");
                        Console.ReadLine();

                    }
                    if (fleet1.robot1.robotHealth <= 0 && fleet1.robot2.robotHealth <= 0 && fleet1.robot3.robotHealth <= 0)
                    {
                        Console.WriteLine(" Millions of years of evolution cannot be halted by the paltry efforts of an inferior creator ! " + herd1.dino1.dinonm + ", of the species, " + herd1.dino1.dinoSpecies
                            + herd1.dino2.dinonm + ", of the species, " + herd1.dino2.dinoSpecies + herd1.dino3.dinonm + ", of the species, " + herd1.dino3.dinoSpecies + "are victorious !! "); Console.ReadLine();


                    }

                    if (herd1.dino1.dinoHlth > 0 && fleet1.robot1.robotHealth > 0)
                    {

                       


                        CommenceAttack1();




                        
                       
                         
                       
                    }

                    
                   

                    if (herd1.dino2.dinoHlth > 0 && fleet1.robot2.robotHealth > 0)
                    {

                        
                      CommenceAttack2();




                    }
                     
                   
                   
                    

                    if (herd1.dino3.dinoHlth > 0 && fleet1.robot3.robotHealth>0)
                    {
                       
                        
                        CommenceAttack3();




                    }
                     









                    break;
                case "no":
                    Console.WriteLine(  "why not?");
                    atkComnd = "yes"; AttackRun();
                    break;
                default: Console.WriteLine(" Please choose YES/NO time is of the essence!! "); AttackRun();
                    break;






            }






           






        }
        public void CommenceAttack1()
        {
            Console.WriteLine(" Round one ");

            if (fleet1.robot1.robotpwrLvl > 0 && herd1.dino1.dinoHlth > 0 && fleet1.robot1.robotHealth > 0)
            {
                herd1.dino1.dinoHlth = herd1.dino1.dinoHlth - fleet1.robot1.weapon.atkpwr;
                fleet1.robot1.robotpwrLvl = fleet1.robot1.robotpwrLvl - fleet1.robot1.weapon.weaponDrain;


                Console.WriteLine( fleet1.robot1.robotName+ " attacked " + herd1.dino1.dinoSpecies+" " + herd1.dino1.dinonm);
                Console.WriteLine(herd1.dino1.dinonm+ " has " + herd1.dino1.dinoHlth + " health left ");
                if (herd1.dino1.dinoHlth <= 0)
                { Console.WriteLine(herd1.dino1.dinonm + " has died!! "); winCntrR++; CommenceAttack2(); }

                SavageReprisal();

                


                Console.ReadLine();
                

            }
            else
            {
                Console.WriteLine(" Power level is " + fleet1.robot1.robotpwrLvl + " The robot ran out of power and must recharge!! ");
                
                Console.ReadLine();
                fleet1.robot1.robotpwrLvl = 100;

                SavageReprisal();


            }


           





        }
        public void CommenceAttack2()
        {

            Console.WriteLine(" Second Round!! ");
            if (fleet1.robot2.robotpwrLvl > 0 && herd1.dino2.dinoHlth > 0 && fleet1.robot2.robotHealth > 0)
            {
                herd1.dino2.dinoHlth = herd1.dino2.dinoHlth - fleet1.robot2.weapon.atkpwr;
                fleet1.robot2.robotpwrLvl = fleet1.robot2.robotpwrLvl - fleet1.robot2.weapon.weaponDrain;


                Console.WriteLine(fleet1.robot2.robotName + " attacked " + herd1.dino2.dinoSpecies + " " + herd1.dino2.dinonm);
                Console.WriteLine(herd1.dino2.dinonm + " has " + herd1.dino2.dinoHlth + " health left ");
                if (herd1.dino2.dinoHlth <= 0)
                { Console.WriteLine(herd1.dino2.dinonm + " has died!! "); winCntrR++;  CommenceAttack3(); }
                Console.ReadLine(); SavageReprisal2();



            }
            else if(herd1.dino2.dinoHlth > 0 && fleet1.robot2.robotHealth > 0)
            {
                Console.WriteLine(" Power level is " + fleet1.robot2.robotpwrLvl + " The robot ran out of power and must recharge!! ");
                
                Console.ReadLine();
                fleet1.robot2.robotpwrLvl = 100;
                SavageReprisal2();



            }
            
        }
        public void CommenceAttack3()
        {
            Console.WriteLine(" Third Round ");

            if (fleet1.robot3.robotpwrLvl > 0 && herd1.dino3.dinoHlth > 0 && fleet1.robot3.robotHealth > 0)
            {
                herd1.dino3.dinoHlth = herd1.dino3.dinoHlth - fleet1.robot3.weapon.atkpwr;
                fleet1.robot3.robotpwrLvl = fleet1.robot3.robotpwrLvl - fleet1.robot3.weapon.weaponDrain;


                Console.WriteLine(fleet1.robot3.robotName + " attacked " + herd1.dino3.dinoSpecies + " " + herd1.dino3.dinonm);
                Console.WriteLine(herd1.dino3.dinonm + " has " + herd1.dino3.dinoHlth + " health left ");
                if (herd1.dino3.dinoHlth <= 0)
                { Console.WriteLine(herd1.dino3.dinonm + " has died!! "); winCntrR++; WinCounter(); }
                Console.ReadLine();
                SavageReprisal3();
                CommenceAttack3();


            }
            else if (herd1.dino3.dinoHlth > 0 && fleet1.robot3.robotHealth > 0)
            {
                Console.WriteLine(" Power level is " + fleet1.robot3.robotpwrLvl + " The robot ran out of power and must recharge!! ");
                
                Console.ReadLine();
                fleet1.robot3.robotpwrLvl = 100;

                SavageReprisal3();


            }
            
        }
        public void SavageReprisal()
        {

            if (herd1.dino1.dinoStam > 0 && herd1.dino1.dinoHlth > 0 && fleet1.robot1.robotHealth > 0)
            {
                fleet1.robot1.robotHealth = fleet1.robot1.robotHealth - herd1.dino1.dinoattk;
                herd1.dino1.dinoStam = herd1.dino1.dinoStam - herd1.dino1.dinoFatigue;
                Console.WriteLine(herd1.dino1.dinoSpecies +" "+herd1.dino1.dinonm + " attacked " +fleet1.robot1.robotName);
                Console.WriteLine(fleet1.robot1.robotName + " has " + fleet1.robot1.robotHealth + " health left ");
                if (fleet1.robot1.robotHealth <= 0) { Console.WriteLine( fleet1.robot1.robotName+ " has ceased functioning "); winCntrd++; CommenceAttack2(); }
                Console.ReadLine();



                CommenceAttack1();












            }
            else if (herd1.dino1.dinoHlth > 0 && fleet1.robot1.robotHealth > 0)
            {
                Console.WriteLine(" Stamina level is " + herd1.dino1.dinoStam + " The Dinosaur is tired and must rest ");
                
                Console.ReadLine();
                herd1.dino1.dinoStam = herd1.dino1.dinoStam + 100; CommenceAttack1();

            }
            
        }


        public void SavageReprisal2()
        {   
            if (herd1.dino2.dinoStam > 0 && herd1.dino2.dinoHlth>0 && fleet1.robot2.robotHealth>0)
            {
                fleet1.robot2.robotHealth = fleet1.robot2.robotHealth - herd1.dino2.dinoattk;
                herd1.dino2.dinoStam = herd1.dino2.dinoStam - herd1.dino2.dinoFatigue;
                Console.WriteLine(herd1.dino2.dinoSpecies + " " + herd1.dino2.dinonm + " attacked " + fleet1.robot2.robotName);
                Console.WriteLine(fleet1.robot2.robotName + " has " + fleet1.robot2.robotHealth + " health left ");
                if (fleet1.robot2.robotHealth <= 0) { Console.WriteLine(fleet1.robot2.robotName + " has ceased functioning "); winCntrd++; CommenceAttack3(); }
                else { CommenceAttack3(); }
                Console.ReadLine();




                CommenceAttack2();




            }
            else if(herd1.dino2.dinoHlth > 0 && fleet1.robot2.robotHealth > 0)
            {
                Console.WriteLine(" Stamina level is " + herd1.dino2.dinoStam + " The Dinosaur is tired and must rest ");
                CommenceAttack2();
                Console.ReadLine();
                herd1.dino2.dinoStam = herd1.dino2.dinoStam + 100;
                CommenceAttack2();










            } 
            
        }
        public void SavageReprisal3()
        {
            if (herd1.dino3.dinoStam > 0 && fleet1.robot3.robotHealth > 0)
            {
                fleet1.robot3.robotHealth = fleet1.robot3.robotHealth - herd1.dino3.dinoattk;
                herd1.dino3.dinoStam = herd1.dino3.dinoStam - herd1.dino3.dinoFatigue;
                Console.WriteLine(herd1.dino3.dinoSpecies + " " + herd1.dino3.dinonm + " attacked " + fleet1.robot3.robotName);
                Console.WriteLine(fleet1.robot3.robotName + " has " + fleet1.robot3.robotHealth + " health left ");
                if (fleet1.robot3.robotHealth <= 0 || herd1.dino3.dinoHlth <= 0) { Console.WriteLine(fleet1.robot3.robotName + " has ceased functioning "); winCntrd++; WinCounter(); }
                CommenceAttack3();
                SavageReprisal3();

                Console.ReadLine();









            }
            else if (herd1.dino3.dinoHlth > 0 && fleet1.robot3.robotHealth > 0)
            {
                Console.WriteLine(" Stamina level is " + herd1.dino3.dinoStam + " The Dinosaur is tired and must rest ");

                Console.ReadLine();
                herd1.dino3.dinoStam = herd1.dino3.dinoStam + 100;

                CommenceAttack3();
            }
            else { WinCounter(); }

            

        }
        public void WinCounter()
        {
            if (winCntrR ==3 || winCntrR>winCntrd)
            {
                Console.WriteLine(" Technology has Prevailed agasint the wilderness!! " + fleet1.robot1.robotName + ", " + fleet1.robot2.robotName + ", " + fleet1.robot3.robotName + " are victorious!! ");
                Console.ReadLine();

            }
            if (winCntrd==3 || winCntrd>winCntrR)
            {
                Console.WriteLine(" Millions of years of evolution cannot be halted by the paltry efforts of an inferior creator ! " + herd1.dino1.dinonm + ", of the species, " + herd1.dino1.dinoSpecies
                    + herd1.dino2.dinonm + ", of the species, " + herd1.dino2.dinoSpecies + herd1.dino3.dinonm + ", of the species, " + herd1.dino3.dinoSpecies + "are victorious !! "); Console.ReadLine();


            }




        }
    }
}
        
